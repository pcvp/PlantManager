using System;
using System.Threading.Tasks;
using PlantManager.Helpers;
using PlantManager.ViewModels.Shared;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace PlantManager.ViewModels.Home
{
    public class HomeViewModel: BaseViewModel
    {
        public HomeViewModel()
        {
        }

        public string Nome => UsuarioHelper.GetNomeDoUsuario();

        public string ImagemDeUsuarioPadrao => "waterdrop.png";

        public ImageSource ImagemDeUsuario { get; set; }

        public Command AlterarFotoCommand => new Command(async () =>
        {
            string action = await Application.Current.MainPage.DisplayActionSheet("Alterar foto do usuário", "Cancelar", null, "Selecionar foto", "Abrir camera");


            switch (action)
            {
                case "Selecionar foto":
                    SelecionarFotoAsync();
                    break;

                case "Abrir camera":

                    AbrirCameraAsync();
                    break;           

            }
        });

        private async Task AbrirCameraAsync()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var armazenamento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "MinhaFoto.jpg"
            };
            var foto = await CrossMedia.Current.TakePhotoAsync(armazenamento);

            if (foto == null)
                return;
            ImagemDeUsuario = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async Task SelecionarFotoAsync()
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagemDeUsuario = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        imagem.Dispose();
                        return stream;
                    });
                }
            }
        }
    }
}
