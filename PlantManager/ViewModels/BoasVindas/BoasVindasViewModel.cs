using System;
using PlantManager.Views.IdentificacaoDoUsario;
using Xamarin.Forms;

namespace PlantManager.ViewModels.BoasVindas
{
    public class BoasVindasViewModel
    {
        public BoasVindasViewModel()
        {
        }

        public Command IrParaAIdentificaoDoUsuarioCommand => new Command(async () =>
        {            
            await Application.Current.MainPage.Navigation.PushAsync(new IdentificacaoDoUsuarioPage());
        });
    }
}
