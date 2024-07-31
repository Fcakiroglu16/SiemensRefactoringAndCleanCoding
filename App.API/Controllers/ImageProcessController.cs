using App.API.AdapterDesignPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageProcessController(IImageProcess imageProcess) : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            imageProcess.AddWatermark("asp.netcore", "abc.jpg", null);
            return Ok();
        }
    }
}