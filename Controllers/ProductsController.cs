using Microsoft.AspNetCore.Mvc;
using NorthwindApi.Data;
using NorthwindApi.Models;

namespace NorthwindApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsRepository _repo;

        public ProductsController(ProductsRepository repo)
        {
            _repo = repo;
        }

        // GET /api/products?page=1&pageSize=10
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            if (page <= 0) page = 1;
            if (pageSize <= 0) pageSize = 10;
            if (pageSize > 200) pageSize = 200;

            var items = await _repo.GetPagedAsync(page, pageSize);
            return Ok(items);
        }

        // GET /api/products/1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById([FromRoute] int id)
        {
            var item = await _repo.GetByIdAsync(id);
            return item is null ? NotFound() : Ok(item);
        }
    }
}
