using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using FloydPink.Flickr.Downloadr.Logic.Extensions;
using FloydPink.Flickr.Downloadr.Logic.Interfaces;
using FloydPink.Flickr.Downloadr.Model;
using FloydPink.Flickr.Downloadr.Model.Constants;
using FloydPink.Flickr.Downloadr.OAuth;
using FloydPink.Flickr.Downloadr.Repository;

namespace FloydPink.Flickr.Downloadr.Logic
{
	public class LoginLogic : ILoginLogic
	{
		private readonly IOAuthManager _oAuthManager;
		private readonly IRepository<Preferences> _preferencesRepository;
		private readonly IRepository<Token> _tokenRepository;
		private readonly IRepository<User> _userRepository;
		private Action<User> _applyUser;

		public LoginLogic (IOAuthManager oAuthManager, IRepository<Token> tokenRepository,
		                        IRepository<User> userRepository, IRepository<Preferences> preferencesRepository)
		{
			_oAuthManager = oAuthManager;
			_tokenRepository = tokenRepository;
			_userRepository = userRepository;
			_preferencesRepository = preferencesRepository;
		}

		#region ILoginLogic Members

		public void Login (Action<User> applyUser)
		{
			_applyUser = applyUser;
			_oAuthManager.Authenticated += OAuthManagerAuthenticated;
			Process.Start (new ProcessStartInfo {
				FileName = _oAuthManager.BeginAuthorization ()
			});
		}

		public void Logout ()
		{
			_tokenRepository.Delete ();
			_userRepository.Delete ();
			_preferencesRepository.Delete ();
		}

		public async Task<bool> IsUserLoggedInAsync (Action<User> applyUser)
		{
			_applyUser = applyUser;
			Token token = _tokenRepository.Get ();
			User user = _userRepository.Get ();
			if (string.IsNullOrEmpty (token.TokenString)) {
				return false;
			}

			_oAuthManager.AccessToken = token.TokenString;
			var testLogin =
				(Dictionary<string, object>)await _oAuthManager.MakeAuthenticatedRequestAsync (Methods.TestLogin);
			bool userIsLoggedIn = (string)testLogin.GetSubValue ("user", "id") == user.UserNsId;

			if (userIsLoggedIn) {
				CallApplyUser (user);
			}
			return userIsLoggedIn;
		}

		#endregion

		private void OAuthManagerAuthenticated (object sender, AuthenticatedEventArgs e)
		{
			User authenticatedUser = e.AuthenticatedUser;
			_userRepository.Save (authenticatedUser);
			CallApplyUser (authenticatedUser);
		}

		private async void CallApplyUser (User authenticatedUser)
		{
			var exraParams = new Dictionary<string, string> {
				{ ParameterNames.UserId, authenticatedUser.UserNsId }
			};
			var userInfo = (Dictionary<string, object>)
                (await _oAuthManager.MakeAuthenticatedRequestAsync (Methods.PeopleGetInfo, exraParams)) [
				                        "person"];
			authenticatedUser.Info = new UserInfo {
				Id = authenticatedUser.UserNsId,
				IsPro = Convert.ToBoolean (userInfo ["ispro"]),
				IconServer = userInfo ["iconserver"].ToString (),
				IconFarm = Convert.ToInt32 (userInfo ["iconfarm"]),
				PathAlias =
                    userInfo ["path_alias"] == null
                        ? string.Empty
                        : userInfo ["path_alias"].ToString (),
				Description = userInfo.GetSubValue ("description").ToString (),
				PhotosUrl = userInfo.GetSubValue ("photosurl").ToString (),
				ProfileUrl = userInfo.GetSubValue ("profileurl").ToString (),
				MobileUrl = userInfo.GetSubValue ("mobileurl").ToString (),
				PhotosCount =
                    Convert.ToInt32 (
					((Dictionary<string, object>)userInfo ["photos"]).GetSubValue (
						"count"))
			};
			_applyUser (authenticatedUser);
		}
	}
}