using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(ServiceResult<T> serviceResult)
        {
            return new ObjectResult(serviceResult) { StatusCode = serviceResult.StatusCode.GetHashCode() };
        }

        [NonAction]
        public IActionResult CreateActionResult(ServiceResult serviceResult)
        {
            return new ObjectResult(serviceResult) { StatusCode = serviceResult.StatusCode.GetHashCode() };
        }
    }
}