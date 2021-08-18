using System;
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
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        [HttpGet("/Weddings/new")]
        public IActionResult New()
        {
            if (!isLoggedIn) {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }
    //Create() talks to form asp-action make sure its the same
        [HttpPost("/weddings/create")]
        public IActionResult Create(Wedding newWedding)
        {

            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("New");
            }

            if (newWedding.Date <= DateTime.Now)
            {
                ModelState.AddModelError("Date", "must be in the future.");
                return View("New");
            }

            // If any above custom errors were added, ModelState would now be invalid.

            // HttpContext.Session.SetString("NameOne", newWedding.NameOne);
            newWedding.UserId = (int)uid;
            db.Weddings.Add(newWedding);
            db.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("/Dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn) {
                return RedirectToAction("Index", "Home");
            }
            
            List<Wedding> allWeddings = db.Weddings.ToList();
            return View("Dashboard", allWeddings);
        }

    }
}