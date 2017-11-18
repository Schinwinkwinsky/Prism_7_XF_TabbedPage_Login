using Android.App;
using Android.Content.PM;
using Android.OS;
using Prism.Unity;
using Unity;

namespace Test.Droid
{
    [Activity(Label = "Test", MainLauncher = true, Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ToolbarResource = Resource.Layout.Toolbar;
            TabLayoutResource = Resource.Layout.Tabbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App(new AndroidInitilizer()));
        }
    }

    public class AndroidInitilizer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
            
        }
    }
}

