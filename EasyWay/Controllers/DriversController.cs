using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWay.Models;

namespace EasyWay.Controllers
{
    public class DriversController : Controller
    {
        // GET: Drivers
        public ViewResult Index()
        {
            var drivers = GetDrivers();
            return View(drivers);
        }

        public ActionResult Details(int id)
        {

            var driver = GetDrivers().SingleOrDefault(d => d.Id == id);
            if (driver == null)
                return HttpNotFound();
            else
                return View(driver);
        }


        private IEnumerable<Driver> GetDrivers()
        {
            return new List<Driver>
            {
                new Driver { Id = 1, Name = "Χαρίλαος Γιαννόπουλος", Phone = 2310521010 },
                new Driver { Id = 2, Name = "Επαμεινώνδας Χαριτάτος",  Phone = 2310521212 },
                new Driver { Id = 3, Name = "Θρασύβουλος Φλώρος", Phone = 231052131313 }
            };
        }
    }
}