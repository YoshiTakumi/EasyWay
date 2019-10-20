using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWay.Models;


namespace EasyWay.Controllers
{
    public class PackagesController : Controller
    {
        private ApplicationDbContext _context;

        public PackagesController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ViewResult Index()
        {
            var packages = _context.Packages.ToList();

           
            return View(packages);
        }

        


        
    }
}