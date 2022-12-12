using Jorge_Rocha_Android_EFP6.Services;
using Jorge_Rocha_Android_EFP6.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jorge_Rocha_Android_EFP6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new WelcomePage());
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
