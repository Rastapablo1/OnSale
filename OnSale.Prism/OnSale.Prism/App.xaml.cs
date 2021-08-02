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
            SyncfusionLicenseProvider.RegisterLicense("NDgyOTU2QDMxMzkyZTMyMmUzMG9WWXhJLzlKNkpVdXI2akd2bFZYaDNiZEFKY05IKzAzcEh5QlRwMXBPMzA9");
            InitializeComponent();
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ProductsPage)}");
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
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailPage, ProductDetailPageViewModel>();
        }
    }
}
