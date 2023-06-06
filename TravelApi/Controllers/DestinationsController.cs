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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> Get()
        {
            return await _db.Destinations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
            Destination destination = await _db.Destinations.FindAsync(id);

            if (destination == null)
            {
                return NotFound();
            }

            return destination;
    }



        }
    }