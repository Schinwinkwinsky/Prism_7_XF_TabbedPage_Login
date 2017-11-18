using System;
using Prism.Commands;
using Prism.Navigation;

namespace Test.ViewModels
{
    public class ViewAViewModel : ChildBaseViewModel
    {
        private string message;
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        private readonly INavigationService _navigationService;

        public DelegateCommand GoToViewC_Command { get; set; }

        public ViewAViewModel(INavigationService navigationService)
        {
            IsActiveChanged += HandleIsActiveTrue;
            //IsActiveChanged += HandleIsActiveFalse;

            _navigationService = navigationService;

            GoToViewC_Command = new DelegateCommand(GoToViewC);
        }

        // Use if there's some code to be executed when the tab is not 
        // the active
        //private void HandleIsActiveFalse(object sender, EventArgs e)
        //{
        //    if (IsActive == true) return;
        //}

        // Use if there's some code to be executed when the tab is the active tab
        private void HandleIsActiveTrue(object sender, EventArgs e)
        {
            if (IsActive == false) return;

            Message = "HandleIsActiveTrue";
        }

        public override void Destroy()
        {
            IsActiveChanged -= HandleIsActiveTrue;
            //IsActiveChanged -= HandleIsActiveFalse;
        }

        // Use the INavigationAware methods (OnNavigatedTo, OnNavigedFrom, OnNavigatingTo)
        // if you want to execute some code when the page is charged using NavigationService.
        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            Message = "OnNavigedTo";
        }

        private async void GoToViewC()
        {
            await _navigationService.NavigateAsync("ViewC");
        }
    }
}
