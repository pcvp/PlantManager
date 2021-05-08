using PlantManager.Helpers;
using PlantManager.Views.BoasVindas;
using PlantManager.Views.Home;
using Xamarin.Forms;


namespace PlantManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(UsuarioHelper.GetNomeDoUsuario()))
            {
                MainPage = new NavigationPage(new BoasVindasPage());
            }
            else
                MainPage = new NavigationPage(new HomePage());
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
