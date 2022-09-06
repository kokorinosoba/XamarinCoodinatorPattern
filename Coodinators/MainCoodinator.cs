using UIKit;

namespace Coodinators
{
    public class MainCoodinator : ICoodinator
    {
        public ICoodinator[] ChildCoodinators { get; set; } = new ICoodinator[] { };
        public UINavigationController NavigationController { get; set; }

        public MainCoodinator(UINavigationController navigationController)
        {
            NavigationController = navigationController;
        }

        public void Start()
        {
            UIViewController vc = StoryboardedExtension<ViewController>.Instantiate();
            NavigationController.PushViewController(vc, animated: false);
        }
    }
}
