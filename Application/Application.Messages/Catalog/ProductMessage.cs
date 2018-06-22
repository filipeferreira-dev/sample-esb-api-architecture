using System;

namespace Application.Messages.Catalog
{
    public class ProductMessage
    {
        public DateTime ExpirationDate { get; set; }

        public string Name { get; set; }

        public long ProductId { get; set; }

        public Guid ProductUuid { get; set; }
    }
}
