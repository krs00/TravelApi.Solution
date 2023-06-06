using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
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

        // GET api/destinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destination>>> Get()
        {


            return await _db.Destinations
                                        .Include(destination => destination.Reviews)
                                        .ToListAsync();
        }

        // GET: api/Destinations/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Destination>> GetDestination(int id)
        {
            Destination destination = await _db.Destinations
                                                            .Include(destination => destination.Reviews)
                                                            .FirstOrDefaultAsync(destination => destination.DestinationId == id);

            if (destination == null)
            {
                return NotFound();
            }

            return destination;
        }


    }
}