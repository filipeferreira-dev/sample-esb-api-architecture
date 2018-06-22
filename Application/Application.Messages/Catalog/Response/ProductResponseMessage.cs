using System.Net.Http;

namespace Application.Messages.Catalog.Request
{
    public class ProductResponseMessage : HttpResponseMessage
    {
        public ProductMessage Product { get; set; }
    }
}
