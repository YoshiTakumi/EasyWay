using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWay.Models;
namespace EasyWay.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var cars = GetCars();
            return View(cars);
        }


        

        private IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car {Id = 1, Brand = "Opel Vivaro", LicensePlate = "NXO 1213"},
                new Car {Id = 2, Brand = "Mercedes Vito", LicensePlate = "IXV 2311"}
            };
        }
    }
}