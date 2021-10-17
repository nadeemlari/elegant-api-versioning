using APIVersion.Web.Contracts;

using Microsoft.AspNetCore.Mvc;

namespace APIVersion.Web.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IActionResult GetProductV1()
        {
            var product = new ProductV1 { Id = 1, Name = "USB Mouse" };

            return Ok(product);
        }
        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult GetProductV2()
        {
            var product = new ProductV2 { Id = 1, ProductName = "USB Mouse" };

            return Ok(product);
        }
    }
}
