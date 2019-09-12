using Foundation;
using LiferayScreens;
using System;
using UIKit;


namespace loginScreenLetiOS
{
    public partial class ViewController : UIViewController//,  ILoginScreenletDelegate
	{
        public ViewController(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //this.loginScreenLettest.Delegate = this;
            //this.loginScreenLet.Delegate = this;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}