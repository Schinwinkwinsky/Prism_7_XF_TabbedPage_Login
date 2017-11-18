using System;
using Prism.Commands;
using Prism.Navigation;

namespace Test.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand Login_Command { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            Login_Command = new DelegateCommand(Login);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            var random = new Random();

            int randomInt = random.Next(2);

            if (randomInt == 0)
                // The User is logged in
                await _navigationService.NavigateAsync("../TabbedViewPage");
            else
                // The User is not logged in
                return;
        }

        private async void Login()
        {
            await _navigationService.NavigateAsync("../TabbedViewPage");
        }


    }
}
