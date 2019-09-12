
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Liferay.Mobile.Screens.Auth.Login;
using Com.Liferay.Mobile.Screens.Context;
using Java.Lang;

namespace BasicLoginScrnLet
{
    [Activity(Label = "SecondActivity", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class SecondActivity : Activity, ILoginListener
    {
        LoginScreenlet testLoginLet;
        public void OnLoginFailure(Java.Lang.Exception p0)
        {
        }

        public void OnLoginSuccess(User p0)
        {
            StartActivity(typeof(WebScreenletActivity));
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.custom_loginscreenlet);
            testLoginLet = (LoginScreenlet)FindViewById(Resource.Id.login_screenlet);
            testLoginLet.Listener = this;
            // Create your application here
        }
    }
}
