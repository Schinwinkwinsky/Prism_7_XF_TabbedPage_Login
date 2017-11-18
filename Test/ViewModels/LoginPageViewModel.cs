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

        private async void Login()
        {
            await _navigationService.NavigateAsync("../TabbedViewPage");
        }
    }
}
