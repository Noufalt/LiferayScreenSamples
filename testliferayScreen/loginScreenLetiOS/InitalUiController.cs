using Foundation;
using LiferayScreens;
using System;
using UIKit;

namespace loginScreenLetiOS
{
    public partial class InitalUiController : UIViewController, ILoginScreenletDelegate
    {
        public InitalUiController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            loginScreenLet.Delegate = this;
        }
    }
}