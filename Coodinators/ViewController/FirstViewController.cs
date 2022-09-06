using System;
using UIKit;

namespace Coodinators
{
    public partial class FirstViewController : UIViewController, ICoodinatedViewController
    {
        WeakReference<MainCoodinator>? ICoodinatedViewController._weakCoodinator { get; set; }

        public FirstViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
