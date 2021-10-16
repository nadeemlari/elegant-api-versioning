using APIVersion.Web.Contracts;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIVersion.Web.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult GetProduct()
        {
            var product = new Product { Id = 1, Name = "USB Mouse" };

            return Ok(product);
        }
    }
}
