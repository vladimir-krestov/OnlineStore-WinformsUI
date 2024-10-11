using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlineStore_WinformsUI
{
    internal class ApiClient : IDisposable
    {
        private const string WebAPIServerUrl = "https://localhost:44303";

        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        public ApiClient()
        {
            _httpClientHandler = new HttpClientHandler()
            {
                CookieContainer = new CookieContainer(),
                UseCookies = true
            };
            _httpClient = new HttpClient(_httpClientHandler);
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            string loginUrl = $"{WebAPIServerUrl}/Authentication/login";

            var requestBody = new
            {
                Email = email,
                Password = password
            };

            string jsonBody = JsonSerializer.Serialize(requestBody);
            StringContent content = new(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                using HttpResponseMessage response = await _httpClient.PostAsync(loginUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch
            {
            }

            return false;
        }

        public async Task<string?> GetDataAsync(string apiUrl, params string[] queryParams)
        {
            try
            {
                string apiQuery = string.Join('&', queryParams);
                var response = await _httpClient.GetAsync($"{WebAPIServerUrl}/{apiUrl}?{apiQuery}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch
            {
            }
            return null;
        }

        public async Task<string> PostDataAsync(string apiUrl, string jsonBody)
        {
            try
            {
                StringContent content = new(jsonBody, Encoding.UTF8, "application/json");

                using HttpResponseMessage response = await _httpClient.PostAsync($"{WebAPIServerUrl}/{apiUrl}", content);

                return await response.Content.ReadAsStringAsync();
            }
            catch
            {
            }

            return HttpStatusCode.InternalServerError.ToString();
        }

        public async Task<Image?> GetImageData(string imageUrl)
        {
            try
            {
                using HttpResponseMessage response = await _httpClient.GetAsync(imageUrl);
                response.EnsureSuccessStatusCode();
                using var stream = await response.Content.ReadAsStreamAsync();

                return Image.FromStream(stream);
            }
            catch
            {
            }

            return null;
        }

        public void Dispose()
        {
            _httpClientHandler.Dispose();
            _httpClient.Dispose();
        }
    }
}
