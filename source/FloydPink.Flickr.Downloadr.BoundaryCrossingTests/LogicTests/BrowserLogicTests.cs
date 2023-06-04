namespace FloydPink.Flickr.Downloadr.BoundaryCrossingTests.LogicTests {
    using System;
    using System.Threading;
    using Bootstrap;
    using Logic.Interfaces;
    using Model;
    using Model.Constants;
    using NUnit.Framework;

    [TestFixture]
    public class BrowserLogicTests {
        [SetUp]
        public async void SetupTest() {
            // do everything to take us to the browser window...
            if (!(await this._loginLogic.IsUserLoggedInAsync(ApplyLoggedInUser))) {
                this._loginLogic.Login(ApplyLoggedInUser);
            }
        }

        private bool _asynchronouslyLoggedIn;
        private IBrowserLogic _logic;
        private ILoginLogic _loginLogic;
        private User _user;

        [TestFixtureSetUp]
        public void SetupTestFixture() {
            Bootstrapper.Initialize();
            this._loginLogic = Bootstrapper.GetInstance<ILoginLogic>();
            this._logic = Bootstrapper.GetInstance<IBrowserLogic>();
        }

        private void ApplyLoggedInUser(User user) {
            this._user = user;
            this._asynchronouslyLoggedIn = true;
        }

        private void WaitTillLoggedIn() {
            while (!this._asynchronouslyLoggedIn) {
                Thread.Sleep(1000);
            }
        }

        [Test]
        public async void GetPublicPhotos_WillGetPublicPhotos() {
            WaitTillLoggedIn();
            var photosResponse =
                await
                    this._logic.GetPhotosAsync(Methods.PeopleGetPublicPhotos, this._user, Preferences.GetDefault(), 1,
                        new Progress<ProgressUpdate>());
            Assert.IsNotNull(photosResponse.Photos);
        }

        [Test]
        public void ProofOfConceptFor_AsynchronousTesting() {
            WaitTillLoggedIn();
            Assert.IsNotNull(this._user);
        }
    }
}
