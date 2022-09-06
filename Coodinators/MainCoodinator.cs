using System;
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
            ((ICoodinatedViewController)vc).Coodinator = new WeakReference<MainCoodinator>(this);
            NavigationController.PushViewController(vc, animated: false);
        }

        public void FirstViewController()
        {
            UIViewController vc = StoryboardedExtension<FirstViewController>.Instantiate();
            ((ICoodinatedViewController)vc).Coodinator = new WeakReference<MainCoodinator>(this);
            NavigationController.PushViewController(vc, animated: true);
        }

        public void SecondViewController()
        {
            UIViewController vc = StoryboardedExtension<SecondViewController>.Instantiate();
            ((ICoodinatedViewController)vc).Coodinator = new WeakReference<MainCoodinator>(this);
            NavigationController.PushViewController(vc, animated: true);
        }
    }
}
