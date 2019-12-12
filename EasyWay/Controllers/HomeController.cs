using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EasyWay.Models;




namespace EasyWay.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            var trips = _context.Trips.Include(t => t.Package).Include(t => t.Driver).Include(t => t.Car).ToList();

            return View(trips);
        }






        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}