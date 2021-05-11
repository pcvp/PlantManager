using PlantManager.Properties;
using Xamarin.Forms;

namespace PlantManager.Helpers
{
    public static class UsuarioHelper
    {
        public static void SetNomeDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.NomeDoUsuarioKey, valor).Wait();

        public static string GetNomeDoUsuario() => LocalDataStoreHelper.GetAsync<string>(KeysResources.NomeDoUsuarioKey).Result;
        

        public static void SetImagemDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.ImagemPadraoDoUsuarioKey, valor).Wait();

        public static ImageSource GetImagemDoUsuario() => LocalDataStoreHelper.GetAsync<string>(KeysResources.ImagemPadraoDoUsuarioKey).Result;



        public static void SetImagemPersonalizadaDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.ImagemPersonalizadaDoUsuarioKey, valor).Wait();
     
        public static string GetImagemDoUsuarioPersonalizada() => LocalDataStoreHelper.GetAsync<string>(KeysResources.ImagemPersonalizadaDoUsuarioKey).Result;
    }
}