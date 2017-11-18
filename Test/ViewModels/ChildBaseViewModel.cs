using System;
using Prism;
using Prism.Navigation;

namespace Test.ViewModels
{
    public class ChildBaseViewModel : BaseViewModel, IActiveAware, IDestructible
    {
        protected static bool HasInitialized { get; set; }

        private bool isActive;
        public bool IsActive 
        { 
            get => isActive; 
            set => SetProperty(ref isActive, value, RaiseIsActiveChanged); 
        }

        public event EventHandler IsActiveChanged;

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        public virtual void Destroy()
        {
            
        }
    }
}
