using System.Threading.Tasks;

namespace PlantManager.Helpers
{
    
    public static class LocalDataStoreHelper {

        public static async Task<T> GetAsync<T>(string key) {
            var valor = await Xamarin.Essentials.SecureStorage.GetAsync(key);

            if (string.IsNullOrWhiteSpace(valor))
                return default;
            try {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(valor);
            }
            catch {
                return default;
            }
        }

        public static Task<string> GetAsync(string key) {
            return GetAsync<string>(key);
        }

        public static async Task SetAsync<T>(string key, T valor) {
            if (valor == null)
                Xamarin.Essentials.SecureStorage.Remove(key);
            else {
                var serializado = Newtonsoft.Json.JsonConvert.SerializeObject(valor);
                await Xamarin.Essentials.SecureStorage.SetAsync(key, serializado);
            }
        }

        public static void Remove(string key) {
            SetAsync<string>(key, null).Wait();
        }
    }
}