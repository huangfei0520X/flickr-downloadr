using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.Messages;
using FloydPink.Flickr.Downloadr.Model;
using FloydPink.Flickr.Downloadr.Model.Constants;
using FloydPink.Flickr.Downloadr.OAuth.Listener;

namespace FloydPink.Flickr.Downloadr.OAuth {
    public class OAuthManager : IOAuthManager {
        private readonly DesktopConsumer _consumer;

        private readonly Dictionary<string, string> _defaultParameters = new Dictionary<string, string> {
            {
                ParameterNames.NoJsonCallback, "1"
            }, {
                ParameterNames.Format, "json"
            }, {
                ParameterNames.Extras,
                AppConstants.ExtraInfo
            }
        };

        private readonly IHttpListenerManager _listenerManager;
        private readonly MessageReceivingEndpoint _serviceEndPoint;

        private string _requestToken = string.Empty;

        public OAuthManager(IHttpListenerManager listenerManager, DesktopConsumer consumer,
                            MessageReceivingEndpoint serviceEndPoint) {
            this._listenerManager = listenerManager;
            this._consumer = consumer;
            this._serviceEndPoint = serviceEndPoint;
        }

        #region IOAuthManager Members

        public string AccessToken { get; set; }

        public event EventHandler<AuthenticatedEventArgs> Authenticated;

        public string BeginAuthorization() {
            if (!this._listenerManager.RequestReceivedHandlerExists) {
                this._listenerManager.RequestReceived += callbackManager_OnRequestReceived;
            }
            this._listenerManager.ResponseString = AppConstants.AuthenticatedMessage;
            this._listenerManager.SetupCallback();
            var requestArgs = new Dictionary<string, string> {
                {
                    ParameterNames.OAuthCallback, this._listenerManager.ListenerAddress
                }
            };
            var redirectArgs = new Dictionary<string, string> {
                {
                    ParameterNames.Permissions, "read"
                }
            };

            return
                this._consumer.RequestUserAuthorization(requestArgs, redirectArgs, out this._requestToken).AbsoluteUri;
        }

        public HttpWebRequest PrepareAuthorizedRequest(IDictionary<string, string> parameters) {
            return this._consumer.PrepareAuthorizedRequest(this._serviceEndPoint, AccessToken, parameters);
        }

        public async Task<dynamic> MakeAuthenticatedRequestAsync(string methodName,
                                                                 IDictionary<string, string> parameters = null) {
            HttpWebRequest request = PrepareAuthorizedRequest(AddRequestParameters(methodName, parameters));
            var response = (HttpWebResponse) await request.GetResponseAsync();
            using (var reader = new StreamReader(response.GetResponseStream())) {
                return (new JavaScriptSerializer()).Deserialize<dynamic>(reader.ReadToEnd());
            }
        }

        private Dictionary<string, string> AddRequestParameters(string methodName,
                                                                IDictionary<string, string> parameters = null) {
            parameters = parameters ?? new Dictionary<string, string>();
            var allParameters = new Dictionary<string, string>(parameters);
            foreach (var kvp in this._defaultParameters) {
                allParameters.Add(kvp.Key, kvp.Value);
            }
            allParameters.Add(ParameterNames.Method, methodName);

            return allParameters;
        }

        #endregion

        private string CompleteAuthorization(string verifier) {
            AuthorizedTokenResponse response = this._consumer.ProcessUserAuthorization(this._requestToken, verifier);
            AccessToken = response.AccessToken;

            IDictionary<string, string> extraData = response.ExtraData;
            var authenticatedUser = new User(extraData["fullname"], extraData["username"], extraData["user_nsid"]);
            Authenticated(this, new AuthenticatedEventArgs(authenticatedUser));

            return response.AccessToken;
        }

        private void callbackManager_OnRequestReceived(object sender, HttpListenerCallbackEventArgs e) {
            string token = e.QueryStrings["oauth_token"];
            string verifier = e.QueryStrings["oauth_verifier"];
            if (token == this._requestToken) {
                CompleteAuthorization(verifier);
            }
        }
    }
}
