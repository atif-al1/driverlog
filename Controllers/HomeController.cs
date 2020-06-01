using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Drivers.Models;

namespace Drivers.Controllers
{

    public class HomeController : Controller
    {
        private TripContext dbContext;
        
        public HomeController(TripContext context){
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.List = dbContext.Trips.ToList();
            return View();
        }

        [HttpPost("Validate")]
        public IActionResult Validate(Trip trip){
            if (ModelState.IsValid)
            {   
                trip.totalTimeDriven=(trip.end - trip.start).TotalHours;
                trip.avgSpeed = trip.miles/trip.totalTimeDriven;

                var findDriver = dbContext.Trips.SingleOrDefault(x => x.driver == trip.driver);

                if (findDriver != null){
                    findDriver.miles += trip.miles;
                    findDriver.totalTimeDriven += trip.totalTimeDriven;
                    findDriver.avgSpeed=findDriver.miles/findDriver.totalTimeDriven;
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                else{
                    dbContext.Trips.Add(trip);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else{
                return View("Index");
            }
        }

    }
}
