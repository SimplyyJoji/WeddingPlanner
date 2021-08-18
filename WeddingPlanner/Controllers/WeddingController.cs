using System.Collections.Generic;
using System.Linq;
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

        [HttpPost("/weddings/create")]
        public IActionResult Create(Wedding newWedding)
        {
            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("New");
            }

            // If any above custom errors were added, ModelState would now be invalid.
        
            db.Weddings.Add(newWedding);
            db.SaveChanges();

            HttpContext.Session.SetInt32("WeddingId", newWedding.WeddingId);
            HttpContext.Session.SetString("NameOne", newWedding.NameOne);
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            List<Wedding> allWeddings = db.Weddings.ToList();
            return View("Dashboard", allWeddings);
        }

    }
}