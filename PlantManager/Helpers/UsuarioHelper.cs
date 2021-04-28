using PlantManager.Properties;
using System;
using Xamarin.Forms;

namespace PlantManager.Helpers
{
    public static class UsuarioHelper
    {
        public static void SetNomeDoUsuario(string valor) => LocalDataStoreHelper.SetAsync(KeysResources.NomeDoUsuarioKey, valor).Wait();

        public static string GetNomeDoUsuario() => LocalDataStoreHelper.GetAsync<string>(KeysResources.NomeDoUsuarioKey).Result;
    }
}