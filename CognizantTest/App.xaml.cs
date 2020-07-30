using System;
using CognizantTest.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CognizantTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
