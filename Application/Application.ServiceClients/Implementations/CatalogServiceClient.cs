using Application.Messages.Catalog.Request;
using Application.ServiceClients.Interfaces;

namespace Application.ServiceClients.Implementations
{
    public partial class CatalogServiceClient : ICatalogServiceClient
    {
        private readonly string host;

        internal CatalogServiceClient(string host)
        {
            this.host = host;
        }

        public ProductResponseMessage GetProductById(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
