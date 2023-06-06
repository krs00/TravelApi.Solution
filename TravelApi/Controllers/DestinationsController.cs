using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace CretaceousApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        private readonly TravelApiContext _db;

        public DestinationsController(TravelApiContext db)
        {
            _db = db;
        }

        // // GET api/animals
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Animal>>> Get()
        // {
        //     return await _db.Animals.ToListAsync();
        // }

        // // GET: api/Animals/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Animal>> GetAnimal(int id)
        // {
        //     Animal animal = await _db.Animals.FindAsync(id);

        //     if (animal == null)
        //     {
        //         return NotFound();
        //     }

        //     return animal;
    // }



        }
    }