using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("/cities")]
        public ActionResult Index()
        {
            List<City> allCities = City.GetAll();
            return View(allCities);
        }

        [HttpGet("/cities/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/cities")]
        public ActionResult Create(string description)
        {
            City myCity = new City(description);
            return RedirectToAction("Index");
        }

        [HttpPost("/cities/delete")]
        public ActionResult DeleteAll()
        {
            City.ClearAll();
            return View();
        }

        [HttpGet("/cities/{id}")]
         public ActionResult Show(int id)
         {
             City city = City.Find(id);
             return View(city);
         }
    }
}
