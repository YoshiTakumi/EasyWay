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

        private ApplicationDbContext _context;


        public DriversController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        
        public ViewResult Index()
        {
            var drivers = _context.Drivers.ToList();

            return View(drivers);
        }



        public ActionResult New()
        {
            var driver = new Driver();
            
            return View("DriversForm", driver);
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Driver driver)
        {
            if(!ModelState.IsValid)
            {
                
                return View("DriversForm");
            }

            if (driver.Id == 0)
                _context.Drivers.Add(driver);

            else
            {
                var driverInDb = _context.Drivers.Single(d => d.Id == driver.Id);
                driverInDb.Name = driver.Name;
                driverInDb.Birthdate = driver.Birthdate;
                driverInDb.Phone = driver.Phone;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Drivers");
        }

        

        public ActionResult Edit (int id)
        {

            var driver = _context.Drivers.SingleOrDefault(d => d.Id == id);
            if (driver == null)
                return HttpNotFound();

            var driverEdit = new Driver
            {
                
                Name = driver.Name,
                Birthdate = driver.Birthdate,
                Phone = driver.Phone
            };

            return View("DriversForm",driverEdit);
        }


       
    }
}