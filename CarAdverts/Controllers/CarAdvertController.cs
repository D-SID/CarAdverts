using CarAdverts.Core.Interface;
using CarAdverts.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarAdverts.Controllers
{
    [ApiController]
    [Route("api/CarAdverts")]
    public class CarAdvertController : ControllerBase
    {
        private readonly ICarAdvertService _service;

        public CarAdvertController(ICarAdvertService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarAdvertDto>>> GetAll()
        {
            var adverts = await _service.GetAllAsync();
            return Ok(adverts);
        }
    }
}
