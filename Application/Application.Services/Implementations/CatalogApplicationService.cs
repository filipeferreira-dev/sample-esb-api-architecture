using Application.Messages.Catalog.Response;
using Application.ServiceClients.Implementations;
using Application.ServiceClients.Interfaces;
using Application.Services.Interfaces;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class CatalogApplicationService : ICatalogApplicationService
    {

        private readonly ICatalogServiceClient catalogServiceClient;


        public CatalogApplicationService()
        {
            catalogServiceClient = CatalogServiceClientFactory.Create();
        }

        public async Task<ProductResponseMessage> GetProductByIdAsync(long id)
        {
            return await catalogServiceClient.GetProductByIdAsync(id);
        }
    }
}
