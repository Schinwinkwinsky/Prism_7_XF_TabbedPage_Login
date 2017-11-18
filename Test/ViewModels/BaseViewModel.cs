using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace Test.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        public BaseViewModel()
        {
        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters) { }

        public virtual void OnNavigatedTo(NavigationParameters parameters) { }

        public virtual void OnNavigatingTo(NavigationParameters parameters) { }
    }
}
