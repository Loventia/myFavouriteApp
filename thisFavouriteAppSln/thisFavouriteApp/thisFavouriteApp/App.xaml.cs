using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace thisFavouriteApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           

            MainPage =   new LandingFlyoutPage();

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
