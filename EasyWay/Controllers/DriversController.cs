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

        }

        public ActionResult Details(int id)
        {

            var driver = _context.Drivers.SingleOrDefault(d => d.Id == id);
            if (driver == null)
                return HttpNotFound();
            else
                return View(driver);
        }


       
    }
}