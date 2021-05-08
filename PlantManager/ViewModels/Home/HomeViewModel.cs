using System;
using System.IO;
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
            var imagemDoUsuarioPersonalizada = UsuarioHelper.GetImagemDoUsuarioMediaFile();
            if (imagemDoUsuarioPersonalizada == null)
                ImagemDoUsuario = UsuarioHelper.GetImagemDoUsuario();
            else
                ImagemDoUsuario = GetImageSourceFromMediaFile(imagemDoUsuarioPersonalizada);
        }

        public string Nome => UsuarioHelper.GetNomeDoUsuario();

        public ImageSource ImagemDoUsuario { get; set; } 

        public Command AlterarFotoCommand => new Command(async () =>
        {
            string action = await Application.Current.MainPage.DisplayActionSheet("Alterar foto do usuário", "Cancelar", null, "Selecionar foto", "Abrir camera");


            switch (action)
            {
                case "Selecionar foto":
                    await SelecionarFotoAsync();
                    break;

                case "Abrir camera":

                    await AbrirCameraAsync();
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

            UsuarioHelper.SetImagemDoUsuario(foto);

            ImagemDoUsuario = GetImageSourceFromMediaFile(foto);
            
        }

        private async Task SelecionarFotoAsync()
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagemDoUsuario = GetImageSourceFromMediaFile(imagem);
                    UsuarioHelper.SetImagemDoUsuario(imagem);
                }
            }
        }

        private ImageSource GetImageSourceFromMediaFile(MediaFile mediaFile)
        {
            return ImageSource.FromStream(() =>
            {
                var stream = mediaFile.GetStream();
                mediaFile.Dispose();
                return stream;
            });
        }
    }
}
