using System;
using UIKit;

namespace Coodinators
{
    public partial class SecondViewController : UIViewController, ICoodinatedViewController
    {
        public WeakReference<MainCoodinator>? Coodinator { get; set; }

        public SecondViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
