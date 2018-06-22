using Application.Messages.Catalog.Request;

namespace Application.ServiceClients.Interfaces
{
    public interface ICatalogServiceClient
    {
        ProductResponseMessage GetProductById(long id); 
    }
}
