using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_android.Services;
using xamarin_android.Views;

namespace xamarin_android
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
