using Foundation;
using UIKit;

namespace Coodinators
{
    public class StoryboardedExtension<Self> : IStoryboarded<Self> where Self : UIViewController
    {
        public static Self Instantiate()
        {
            string id = typeof(Self).Name;
            UIStoryboard storyboard = UIStoryboard.FromName(
                name: "Main",
                storyboardBundleOrNil: NSBundle.MainBundle);

            return (Self)storyboard.InstantiateViewController(identifier: id);
        }
    }
}
