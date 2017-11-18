using Prism.Unity;
using Test.Views;
using Xamarin.Forms;

namespace Test
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null)
            : base(initializer) { }
        

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<TabbedViewPage>();
            Container.RegisterTypeForNavigation<ViewA>();
            Container.RegisterTypeForNavigation<ViewB>();
            Container.RegisterTypeForNavigation<ViewC>();
        }
    }
}

