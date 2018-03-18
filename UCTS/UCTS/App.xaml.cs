using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UCTS.Views;

using Xamarin.Forms;

namespace UCTS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnResume()
        {
            //MainPage = new NavigationPage(new MainPage());
            // Handle when your app resumes
        }
    }
}
