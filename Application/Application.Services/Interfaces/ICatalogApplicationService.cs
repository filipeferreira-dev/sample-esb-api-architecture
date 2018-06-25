using Application.Messages.Catalog.Response;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ICatalogApplicationService
    {
        Task<ProductResponseMessage> GetProductByIdAsync(long id);
    }
}
