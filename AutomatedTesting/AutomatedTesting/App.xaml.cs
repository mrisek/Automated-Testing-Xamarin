using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AutomatedTesting.Services;
using AutomatedTesting.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AutomatedTesting
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
            // Initialize the SDK with the list of services to start.
            // This may be called only once per application process lifetime.
            AppCenter.Start("android=b04341fc-4898-4336-9492-118981345a78",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
