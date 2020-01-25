using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fludder_Beta_VS.Services;
using Fludder_Beta_VS.Views;

namespace Fludder_Beta_VS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
