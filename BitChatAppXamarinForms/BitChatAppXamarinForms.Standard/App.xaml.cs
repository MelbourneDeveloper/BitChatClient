namespace Adapt.PresentationSamples
{
    public partial class App
    {
        #region Constructor
        public App()
        {
            var mainPage = new MainPage();

            InitializeComponent();
            MainPage = mainPage;
        }
        #endregion

        #region App Events
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
