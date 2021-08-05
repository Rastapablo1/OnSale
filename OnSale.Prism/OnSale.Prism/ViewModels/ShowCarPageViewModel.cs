using OnSale.Prism.Helpers;
using Prism.Navigation;

namespace OnSale.Prism.ViewModels
{
    internal class ShowCarPageViewModel : ViewModelBase
    {
        public ShowCarPageViewModel(INavigationService navigationService)
            : base (navigationService)
        {
            Title = Languages.ShowShoppingCar;
        }

    }
}

