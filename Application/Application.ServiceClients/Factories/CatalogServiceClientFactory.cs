namespace Application.ServiceClients.Implementations
{
    public partial class CatalogServiceClientFactory
    {
        public static CatalogServiceClient Create()
        {
            return new CatalogServiceClient("teste");
        }
    }
}
