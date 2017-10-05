using System;

using UIKit;

namespace CodePushDemo
{
    public partial class MyFirstView : UIViewController
    {
        public MyFirstView() : base("MyFirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            btnTest.TouchUpInside+= (sender, e) => 
            {
                UIAlertView al = new UIAlertView("Distribute Demo", txtField.Text, null, "OKay", null);
                al.Show();
            };
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

