using CarAdverts.Core.Interface;
using CarAdverts.Core.Models;
using CarAdverts.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarAdverts.Controllers;

[ApiController]
[Route("api/caradverts")]
public class CarAdvertController : ControllerBase
{
    private readonly ICarAdvertService _service;

    public CarAdvertController(ICarAdvertService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarAdvertDto>>> GetAll(string? sortBy)
    {
        var adverts = await _service.GetAllAsync(sortBy);

        return Ok(adverts);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CarAdvertDto>> GetById(int id)
    {
        var advert = await _service.GetByIdAsync(id);
        if (advert == null)
        {
            return NotFound();
        }

        return Ok(advert);
    }

    [HttpPost]
    public async Task<ActionResult<CarAdvertDto>> Create([FromBody] CarAdvertDto carAdvertDto)
    {
        if (!carAdvertDto.New && (carAdvertDto.Mileage == null || carAdvertDto.FirstRegistration == null))
        {
            return BadRequest("Mileage and Registration are required for used car.");
        }

        var newAdvert = await _service.CreateAsync(carAdvertDto);

        return CreatedAtAction(nameof(GetById), new { id = newAdvert.Id }, newAdvert);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] CarAdvertDto carAdvertDto)
    {
        await _service.UpdateAsync(carAdvertDto);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);

        return NoContent();
    }
}
