using CreditCardUISample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditCardUISample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new CreditCardPage());
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
