﻿namespace FloydPink.Flickr.Downloadr.Logic {
    using System;
    using System.IO;
    using System.Net;
    using System.Reflection;
    using Interfaces;
    using Model;
    using Repository;
    using log4net;

    public class UpdateCheckLogic : IUpdateCheckLogic {
        private readonly IRepository<Update> _repository;
        private static readonly ILog Log = LogManager.GetLogger(typeof(UpdateCheckLogic));


        public UpdateCheckLogic(IRepository<Update> repository) {
            this._repository = repository;
        }

        #region IUpdateCheckLogic implementation

        public Update UpdateAvailable(Preferences preferences) {
            try
            {
                var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
                Version latestVersion;
                var update = this._repository.Get();
                if (DateTime.Now.Subtract(TimeSpan.FromDays(1.0)) > update.LastChecked)
                {
                    var request = WebRequest.Create("http://flickrdownloadr.com/build.number");
                    var response = (HttpWebResponse)request.GetResponse();
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        latestVersion = new Version(reader.ReadToEnd());
                    }
                    update.LastChecked = DateTime.Now;
                    update.LatestVersion = latestVersion.ToString();
                }
                else {
                    latestVersion = new Version(update.LatestVersion);
                }
                update.Available = latestVersion.CompareTo(currentVersion) > 0;
                this._repository.Save(update);
                return update;
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Unexpected exception in UpdateCheckLogic::UpdateAvailble method\n\n{0}", ex));
                return null;
            }
        }

        #endregion
    }
}
