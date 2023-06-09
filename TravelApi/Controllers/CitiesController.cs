using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CitiesController : ControllerBase
  {
    private readonly TravelApiContext _db;

    public CitiesController(TravelApiContext db)
    {
      _db = db;
    }

    // GET api/cities
    [HttpGet]
    public async Task<ActionResult<IEnumerable<City>>> Get()
    {


      return await _db.Cities
                                  .Include(city => city.Reviews)
                                  .ToListAsync();
    }

    // GET: api/cities/3
    [HttpGet("{id}")]
    public async Task<ActionResult<City>> GetCity(int id)
    {
      City city = await _db.Cities
                                                      .Include(city => city.Reviews)
                                                      .FirstOrDefaultAsync(city => city.CityId == id);

      if (city == null)
      {
        return NotFound();
      }

      return city;
    }

    // POST api/cities
    [HttpPost]
    public async Task<ActionResult<City>> Post(City city)
    {
      _db.Cities.Add(city);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetCity), new { id = city.CityId }, city);
    }


    // PUT: api/cities/3
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, City city)
    {
      if (id != city.CityId)
      {
        return BadRequest();
      }

      _db.Cities.Update(city);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CityExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool CityExists(int id)
    {
      return _db.Cities.Any(e => e.CityId == id);
    }

    // DELETE: api/Cities/3
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCity(int id)
    {
      City city = await _db.Cities.FindAsync(id);
      if (city == null)
      {
        return NotFound();
      }

      _db.Cities.Remove(city);
      await _db.SaveChangesAsync();

      return NoContent();
    }






  }
}