
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
using Com.Liferay.Mobile.Screens.Context;
using Com.Liferay.Mobile.Screens.Web;
using Java.Lang;
using static Com.Liferay.Mobile.Screens.Web.WebScreenletConfiguration;

namespace BasicLoginScrnLet
{
    [Activity(Label = "WebScreenletActivity")]
    public class WebScreenletActivity : Activity,IWebListener
    {
        WebScreenlet webScreenlet;
        public void Error(Java.Lang.Exception p0, string p1)
        {
           // throw new NotImplementedException();
        }

        public void OnPageLoaded(string p0)
        {
            //throw new NotImplementedException();
        }

        public void OnScriptMessageHandler(string p0, string p1)
        {
            //throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.web_screenlet_view);

            webScreenlet = (WebScreenlet)FindViewById(Resource.Id.web_screenlet_screenlet);
            loadWebScreenlet();
            // Create your application here
        }

        private void loadWebScreenlet()
        {
            WebScreenletConfiguration webScreenletConfiguration = new WebScreenletConfiguration
                .Builder("/web/guest/myprofile")
                .SetWebType(WebType.LiferayAuthenticated)
                //.AddRawJs(Resource.Raw.js_master, "js_master.js")
                //.AddRawCss(Resource.Raw.css_master, "css_master.css")
                .Load();
            var loggedInFlag=SessionContext.IsLoggedIn;
            webScreenlet.SetWebScreenletConfiguration(webScreenletConfiguration);
            webScreenlet.Listener = this;

            webScreenlet.Load();
        }
    }
}
