using CleanCar.Application.DTOs;
using CleanCar.Application.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;
        public CidadeController(ICidadeService cidadeService) 
        {
            _cidadeService = cidadeService;
        }

        [HttpGet]
        public async Task<CidadeDTO> Created([FromBody] CidadeDTO cidade)
        {
            return await _cidadeService.Created(cidade);
        }
    }
}
