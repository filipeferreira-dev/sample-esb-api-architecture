using Application.Messages.Catalog.Response;
using Application.ServiceClients.Interfaces;
using CustomLibrary;
using System.Threading.Tasks;

namespace Application.ServiceClients.Implementations
{
    public partial class CatalogServiceClient : ICatalogServiceClient
    {
        private readonly string host;
        private readonly HttpRestClient httpRestClient;

        internal CatalogServiceClient(string host)
        {
            this.host = host;
            httpRestClient = new HttpRestClient(this.host);
        }

        public async Task<ProductResponseMessage> GetProductByIdAsync(long id)
        {
            return await httpRestClient.GetAsync<ProductResponseMessage>($"api/product/{id}");
        }
    }
}
