using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomLibrary
{
    public class HttpRestClient
    {
        private readonly HttpClient httpClient;

        public HttpRestClient(string baseAddress)
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        public async Task<T> GetAsync<T>(string path) where T : HttpResponseMessage, new()
        {
            try
            {
                var responseMessage = await httpClient.GetAsync(path);
                return JsonConvert.DeserializeObject<T>(await responseMessage.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException e)
            {
                var response = Activator.CreateInstance<T>();

                response.Content = new StringContent(e.GetBaseException().Message);
                response.StatusCode = HttpStatusCode.BadGateway;

                return response;
            }
            catch (Exception e)
            {
                var response = Activator.CreateInstance<T>();

                response.Content = new StringContent(e.GetBaseException().Message);
                response.StatusCode = HttpStatusCode.BadGateway;

                return response;
            }
        }
    }
}
