using System;
using System.Threading.Tasks;
using PlantManager.Helpers;
using PlantManager.ViewModels.Shared;
using PlantManager.Views.BoasVindas;
using PlantManager.Views.Home;
using PlantManager.Views.IdentificacaoDoUsario;
using Xamarin.Forms;

namespace PlantManager.ViewModels.IdentificacaoDoUsuario
{
    public class IdentificacaoDoUsuarioViewModel: BaseViewModel
    {
        public IdentificacaoDoUsuarioViewModel()
        {
        }

        public string Emoji => EmojiName + ".png";

        private string EmojiName => string.IsNullOrEmpty(Nome) ? "Emoji1" : "Emoji2";

        public string Nome { get; set; }
        
        public Command SalvarUsuarioCommand => new Command(async () =>
        {
            UsuarioHelper.SetNomeDoUsuario(Nome);
            UsuarioHelper.SetImagemDoUsuario("Waterdrop.png");
            IrParaHome();
        });

        private void IrParaHome()
        {
            Application.Current.MainPage = new NavigationPage(new HomePage());
        }
    }
}
