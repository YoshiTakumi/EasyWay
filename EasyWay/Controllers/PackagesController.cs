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

            var viewModel = new PackageFormViewModel
            {
                SizeOfPackages = sizeOfPackage,
                ChargeOfPackages = chargeOfPackage
            };
            
            return View("PackageForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Package package)
        {
            if(package.Id == 0)
                _context.Packages.Add(package);
            else
            {
                var packageInDb = _context.Packages.Single(p => p.Id == package.Id);
                packageInDb.Sender = package.Sender;
                packageInDb.Receiver = package.Receiver;
                packageInDb.ReceiverAddress = package.ReceiverAddress;
                packageInDb.SerialNumber = package.SerialNumber;
                packageInDb.DateLeft = package.DateLeft;
                packageInDb.Phone = package.Phone;
                packageInDb.SizeOfPackageId = package.SizeOfPackageId;
                packageInDb.ChargeOfPackageId = package.ChargeOfPackageId;


            }


            _context.SaveChanges();


            return RedirectToAction("Index", "Packages");
        }


        public ActionResult Edit(int id)
        {
            var package = _context.Packages.SingleOrDefault(p => p.Id == id);

            if (package == null)
                return HttpNotFound();
            var viewModel = new PackageFormViewModel
            {
                Package = package,
                SizeOfPackages = _context.SizeOfPackages.ToList(),
                ChargeOfPackages = _context.ChargeOfPackages.ToList()
            };

            return View("PackageForm", viewModel);
          

        }
        


        
    }
}