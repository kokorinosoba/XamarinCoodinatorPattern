using UIKit;

namespace Coodinators
{
    public interface ICoodinator
    {
        public ICoodinator[] ChildCoodinators { get; set; }
        public UINavigationController NavigationController { get; set; }

        public void Start();
    }
}
