using Foundation;
using LiferayScreens;
using System;
using UIKit;

namespace testIOSTemp
{
    public partial class ViewController : UIViewController, LiferayScreens.ILoginScreenletDelegate
    {
        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            loginScreenlet.ThemeName = "demo";
            loginScreenlet.Delegate = this;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        [Export("screenlet:onLoginError:")]
        public virtual void OnLoginError(BaseScreenlet screenlet, NSError error)
        {
            Console.WriteLine($"Login failed: {error.Description}");
        }

        [Export("screenlet:onLoginResponseUserAttributes:")]
        public virtual void OnLoginResponseUserAttributes(BaseScreenlet screenlet, NSDictionary<NSString, NSObject> attributes)
        {
            Console.WriteLine($"Login successful: {attributes}");

            //Console.WriteLine("Navigate to SelectScreenletViewController");
            //UIStoryboard board = UIStoryboard.FromName("SelectScreenlet", null);
            //SelectScreenletViewController vc = (SelectScreenletViewController)
            //    board.InstantiateViewController("SelectScreenletViewController");
            //this.NavigationController.PushViewController(vc, true);
        }

    }
}