using System;
using System.IO;
using System.Threading.Tasks;
using PlantManager.Helpers;
using PlantManager.ViewModels.Shared;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PlantManager.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            var imagemDoUsuarioPersonalizada = UsuarioHelper.GetImagemDoUsuarioPersonalizada();
            if (imagemDoUsuarioPersonalizada == null)
                ImagemDoUsuario = UsuarioHelper.GetImagemDoUsuario();
            else
                ImagemDoUsuario = imagemDoUsuarioPersonalizada;
        }

        public string Nome => UsuarioHelper.GetNomeDoUsuario();

        public ImageSource ImagemDoUsuario { get; set; }

        public Command AlterarFotoCommand => new Command(async () =>
        {
            string action = await Application.Current.MainPage.DisplayActionSheet("Alterar foto do usuário", "Cancelar", null, "Selecionar foto", "Abrir camera");
            string path = string.Empty;

            switch (action)
            {
                case "Selecionar foto":
                    path = await SelecionarFotoAsync();
                    break;

                case "Abrir camera":
                    path = await TirarFotoAsync();
                    break;

            }

            if (!string.IsNullOrEmpty(path))
            {
                ImagemDoUsuario = path;
                UsuarioHelper.SetImagemPersonalizadaDoUsuario(path);
            }

        });



        public async Task<string> SelecionarFotoAsync()
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                return await LoadPhotoAsync(photo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SelecionarFotoAsync THREW: {ex.Message}");
                return null;
            }
        }

        public async Task<string> TirarFotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                return await LoadPhotoAsync(photo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"TirarFotoAsync THREW: {ex.Message}");
                return null;
            }
        }

        async Task<string> LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                return null;
            }
            // save the file into local storage
            var newFile = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);
            using (var stream = await photo.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            return newFile;
        }
    }
}
