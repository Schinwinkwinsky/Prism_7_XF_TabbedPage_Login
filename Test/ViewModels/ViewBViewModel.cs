using System;
using Prism.Navigation;

namespace Test.ViewModels
{
    public class ViewBViewModel : ChildBaseViewModel
    {
        public ViewBViewModel()
        {
            IsActiveChanged += HandleIsActiveTrue;
            IsActiveChanged += HandleIsActiveFalse;
        }

        private void HandleIsActiveFalse(object sender, EventArgs e)
        {
            if (IsActive == true) return;
        }

        private void HandleIsActiveTrue(object sender, EventArgs e)
        {
            if (IsActive == false) return;
        }

        public override void Destroy()
        {
            IsActiveChanged -= HandleIsActiveTrue;
            IsActiveChanged -= HandleIsActiveFalse;
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (HasInitialized) return;

            HasInitialized = true;
        }
    }
}
