using Microsoft.AspNetCore.Mvc;
using motoApi.Models;
using motoApi.Services;
using static motoApi.Services.MotoService;

namespace motoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotoController : ControllerBase
    {
        private readonly MotoServices _motoServices;

        public MotoController(MotoServices motoServices)
        {
            _motoServices = motoServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var motos = _motoServices.GetAll();
            return Ok(motos);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Moto moto)
        {
            await _motoServices.CreateAsync(moto);
            return Ok();
        }
    }
}
