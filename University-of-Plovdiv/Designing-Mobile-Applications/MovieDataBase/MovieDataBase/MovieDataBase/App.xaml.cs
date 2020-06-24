using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MovieDataBase.Views;

namespace MovieDataBase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NavPage()
            {
                BarBackgroundColor = Color.Black
            });
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
