using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var packages = _context.Packages.Include(p => p.SizeOfPackage).Include(p => p.ChargeOfPackage).ToList();

           
            return View(packages);
        }

        


        
    }
}