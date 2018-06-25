using Application.Messages.Catalog.Response;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Esb.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ICatalogApplicationService catalogApplicationService;

        public ProductController(ICatalogApplicationService catalogApplicationService)
        {
            this.catalogApplicationService = catalogApplicationService;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<ProductResponseMessage> GetProductByIdAsync(long id)
        {
            return await catalogApplicationService.GetProductByIdAsync(id);
        }
    }
}