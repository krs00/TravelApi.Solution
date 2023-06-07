using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TravelApiContext _db;

        public UsersController(TravelApiContext db)
        {
            _db = db;
        }


        // GET api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {


            return await _db.Users
                                        .Include(user => user.Reviews)
                                        .ToListAsync();
        }


        // GET: api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User user = await _db.Users
                                                            .Include(user => user.Reviews)
                                                            .FirstOrDefaultAsync(user => user.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // Add User to DB
        // POST api/users
        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }

        // // PUT: api/Users/5/reviews/
        // [HttpPut("{Id}/reviews/{reviewId}")]
        // public async Task<IActionResult> Put([FromBody] Review bodyreview)
        // {

        //     Review thisReview = await _db.Reviews.FindAsync();

        //     if (id != animal.AnimalId)
        //     {
        //         return BadRequest();
        //     }
        // }

        //     _db.Animals.Update(animal);

        //     try
        //     {
        //         await _db.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!AnimalExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // private bool AnimalExists(int id)
        // {
        //     return _db.Animals.Any(e => e.AnimalId == id);
        // }




    }
}