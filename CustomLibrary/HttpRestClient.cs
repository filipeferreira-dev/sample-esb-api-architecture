using System;
using System.Net.Http;

namespace CustomLibrary
{
    public class HttpRestClient
    {
        private readonly HttpClient httpClient;

        public HttpRestClient(string baseAddress)
        {
            httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri(baseAddress);
        }
    }
}
