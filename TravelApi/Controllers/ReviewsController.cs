using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace CretaceousApi.Controllers
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



    }
}