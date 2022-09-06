using System;
using UIKit;

namespace Coodinators
{
    public partial class SecondViewController : UIViewController, ICoodinatedViewController
    {
        WeakReference<MainCoodinator>? ICoodinatedViewController._weakCoodinator { get; set; }

        public SecondViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
