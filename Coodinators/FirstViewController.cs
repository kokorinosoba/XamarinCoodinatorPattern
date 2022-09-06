using System;
using UIKit;

namespace Coodinators
{
    public partial class FirstViewController : UIViewController, ICoodinatedViewController
    {
        public WeakReference<MainCoodinator>? Coodinator { get; set; }

        public FirstViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
