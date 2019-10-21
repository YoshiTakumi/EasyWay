using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWay.Models;
using EasyWay.ViewModels;


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

        public ActionResult New()
        {
            var sizeOfPackage = _context.SizeOfPackages.ToList();
            var chargeOfPackage = _context.ChargeOfPackages.ToList();

            var viewModel = new NewPackageViewModel
            {
                SizeOfPackages = sizeOfPackage,
                ChargeOfPackages = chargeOfPackage
            };
            
            return View(viewModel);
        }

        


        
    }
}