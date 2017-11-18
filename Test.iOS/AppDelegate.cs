using Foundation;
using Prism.Unity;
using UIKit;
using Unity;

namespace Test.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            Xamarin.Forms.Forms.Init();

            LoadApplication(new App(new IOSInitializer()));

            return base.FinishedLaunching(application, launchOptions);
        }
    }

    public class IOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            
        }
    }
}

