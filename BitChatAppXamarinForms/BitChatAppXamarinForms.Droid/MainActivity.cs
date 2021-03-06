﻿
using Adapt.Presentation.AndroidPlatform;
using Adapt.PresentationSamples;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using xf = Xamarin.Forms;

namespace XamForms.Droid
{
    [Activity(Label = "Bit Chat", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : xf.Platform.Android.FormsApplicationActivity, IRequestPermissionsActivity
    {
        #region Fields
        private PresentationFactory _PresentationFactory;
        #endregion

        #region Events
        public event PermissionsRequestCompletedHander PermissionsRequestCompleted;
        #endregion

        #region Protected Overrides
        protected override void OnCreate(Bundle bundle)
        {
            var permissions = new Permissions(this);
            _PresentationFactory = new PresentationFactory(this, permissions);
            base.OnCreate(bundle);
            xf.Forms.Init(this, bundle);
            MainPage.Permissions = new Permissions(this);
            LoadApplication(new App());
        }
        #endregion

        #region Public Overrides
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            PermissionsRequestCompleted?.Invoke(requestCode, permissions, grantResults);
        }

        protected override void OnStop()
        {
            base.OnStop();
            //TODO: We should dispose when the app shuts down, but for some reason this event fires even when the app is not shutting down
            //_PresentationFactory.Dispose();
        }

        #endregion
    }
}

