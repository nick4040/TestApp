using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace TestApp.Services
{
    public class ApiMethods
    {
        

       public static async Task<string> PostAsync(Dictionary<string, object> parameters, string url)
        {

            string AuthKey = TestApp.Common.Constants.AuthKey;
            string AuthToken = TestApp.Common.Constants.AuthToken;

            using HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
            httpClient.DefaultRequestHeaders.Add("apikey", AuthKey);

            string json = System.Text.Json.JsonSerializer.Serialize(parameters);
            using StringContent jsonContent = new StringContent(json, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await httpClient.PostAsync(url, jsonContent);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }


        public static async Task<string> GetAsync(string apiUrl)
        {

            string AuthKey = TestApp.Common.Constants.AuthKey;
            string AuthToken = TestApp.Common.Constants.AuthToken;

            using HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthToken);
            httpClient.DefaultRequestHeaders.Add("apikey", AuthKey);

            using HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            return jsonResponse;
        }

        public static TestApp.Common.Constants.CustomerData ParseJson(String jsonString)
        {
            return JsonConvert.DeserializeObject<TestApp.Common.Constants.CustomerData>(jsonString);
        }

    }
}
