using OnSale.Commom.Services;
using OnSale.Prism.ViewModels;
using OnSale.Prism.Views;
using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using System;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace OnSale.Prism
{
    public partial class App
    {   

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("NDc2OTI1QDMxMzkyZTMyMmUzMGE0a1ExSXY5dmRnWkFoWjZ5bENwckt2RG9vSWhZOHhvVE52N1o2QVNPMkE9");
            InitializeComponent();
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ProductPage)}");
        }   

        private object ProductPage()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ProductPage, ProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailPage, ProductDetailPageViewModel>();
        }
    }
}
