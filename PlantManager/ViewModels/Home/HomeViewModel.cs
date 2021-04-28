using System;
using PlantManager.Helpers;
using PlantManager.ViewModels.Shared;

namespace PlantManager.ViewModels.Home
{
    public class HomeViewModel: BaseViewModel
    {
        public HomeViewModel()
        {
        }

        public string Nome => UsuarioHelper.GetNomeDoUsuario();
    }
}
