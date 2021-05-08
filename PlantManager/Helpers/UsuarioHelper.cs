using PlantManager.Properties;
using Plugin.Media.Abstractions;
using System;
using System.IO;
using Xamarin.Forms;

namespace PlantManager.Helpers
{
    public static class UsuarioHelper
    {
        public static void SetNomeDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.NomeDoUsuarioKey, valor).Wait();

        public static string GetNomeDoUsuario() => LocalDataStoreHelper.GetAsync<string>(KeysResources.NomeDoUsuarioKey).Result;
        

        public static void SetImagemDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.ImagemPadraoDoUsuarioKey, valor).Wait();

        public static ImageSource GetImagemDoUsuario() => LocalDataStoreHelper.GetAsync<string>(KeysResources.ImagemPadraoDoUsuarioKey).Result;



        public static void SetImagemDoUsuario(MediaFile valor) => LocalDataStoreHelper.SetAsync(KeysResources.ImagemPersonalizadaDoUsuarioKey, valor).Wait();
     
        public static MediaFile GetImagemDoUsuarioMediaFile() => LocalDataStoreHelper.GetAsync<MediaFile>(KeysResources.ImagemPersonalizadaDoUsuarioKey).Result;
    }
}