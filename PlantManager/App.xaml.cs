using System;
using PlantManager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlantManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BoasVindasPage();
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
