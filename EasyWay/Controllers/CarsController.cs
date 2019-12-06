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
        private ApplicationDbContext _context;


        public CarsController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            var cars = _context.Cars.ToList();

            return View(cars);
        }


        public ActionResult New()
        {
            var car = new Car();
            
            return View("CarsForm", car);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Car car)
        {
            if(!ModelState.IsValid)
            {
                return View("CarsForm");
            }

            if (car.Id == 0)
                _context.Cars.Add(car);
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);
                carInDb.Brand = car.Brand;
                carInDb.YearManufactured = car.YearManufactured;
                carInDb.LicensePlate = car.LicensePlate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cars");
        }



        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (car == null)
                return HttpNotFound();

            var carEdit = new Car
            {
                Brand = car.Brand,
                YearManufactured = car.YearManufactured,
                LicensePlate = car.LicensePlate
            };

            return View("CarsForm", carEdit);
        }

        
    }
}