using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IProductService productService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ProductDto product)
        {
            productService.Add(product);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = productService.GetAll();
            return Ok(products);
        }

        [HttpDelete]
        public IActionResult Delete(ProductDto product)
        {
            productService.Delete(product);
            return Ok();
        }
    }
}