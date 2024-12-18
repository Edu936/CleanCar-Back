using CleanCar.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Olá mundo";
        }

    }
}
