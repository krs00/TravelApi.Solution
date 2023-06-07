using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly TravelApiContext _db;

        public ReviewsController(TravelApiContext db)
        {
            _db = db;
        }

        // // GET api/reviews
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Review>>> Get()
        // {
        //     return await _db.Reviews.ToListAsync();
        // }

        // GET: api/Reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> Get(int cityid)
        {
            IQueryable<Review> query = _db.Reviews.AsQueryable();

            if (cityid > 0)
            {
                query = query.Where(entry => entry.CityId == cityid);
            }

            return await query.ToListAsync();
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            Review review = await _db.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // POST api/reviews
        [HttpPost()]
        public async Task<ActionResult<Review>> Post(Review review)
        {
            _db.Reviews.Add(review);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetReview), new { id = review.ReviewId }, review);


            // // PUT: api/Animals/5
            // [HttpPut("{id}")]
            // public async Task<IActionResult> Put(int UserId, [FromBody] Review review)
            // {
            //     if (UserId != review.UserId)
            //     {
            //         return BadRequest();
            //     }

            //     _db.Animals.Update(animal);

        }


        // PUT: api/Reviews/4
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Review review)
        {

            Review currentReview = await _db.Reviews
                                .FirstOrDefaultAsync(review => review.ReviewId == id);

            if (currentReview == null)
            {
                return NotFound("I can't find that review");
            }

            if (currentReview.UserId != review.UserId)
            {
                return BadRequest("You are not the owner of this review!");
            }
            _db.Reviews.Update(review);

            return NoContent();
        }


        // DELETE: api/review/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            Review review = await _db.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _db.Reviews.Remove(review);
            await _db.SaveChangesAsync();

            return NoContent();
        }


    }
}
