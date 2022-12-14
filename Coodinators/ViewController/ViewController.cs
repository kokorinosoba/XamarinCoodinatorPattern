using System;
using Foundation;
using UIKit;

namespace Coodinators
{
    public partial class ViewController : UIViewController, ICoodinatedViewController
    {
        WeakReference<MainCoodinator>? ICoodinatedViewController._weakCoodinator { get; set; }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void FirstViewControllerTapped(NSObject sender)
        {
            ((ICoodinatedViewController)this).Coodinator.FirstViewController();
        }

        partial void SecondViewControllerTapped(NSObject sender)
        {
            ((ICoodinatedViewController)this).Coodinator.FirstViewController();
        }
    }
}
