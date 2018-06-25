using System.Net.Http;

namespace Application.Messages.Catalog.Response
{
    public class ProductResponseMessage : HttpResponseMessage
    {
        public ProductMessage Product { get; set; }
    }
}
