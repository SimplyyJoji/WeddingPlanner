using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private UserWeddingContext db;
        public WeddingController(UserWeddingContext context)
        {
            db = context;
        }

        [HttpGet("/Weddings/new")]
        public IActionResult New()
        {
            return View("New");
        }


    }
}