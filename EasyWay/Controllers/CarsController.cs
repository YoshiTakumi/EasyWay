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

        

        public ActionResult Index()
        {
            var cars = _context.Cars.ToList();

            return View(cars);
        }


        

        
    }
}