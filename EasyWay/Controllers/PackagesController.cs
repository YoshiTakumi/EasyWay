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

            if (User.IsInRole(RoleName.CanManagePackages))
                return View("Index");
            return View("ReadOnlyList");
            
          
            
        }

        [Authorize(Roles = RoleName.CanManagePackages)]
        public ActionResult New()
        {
            var sizeOfPackage = _context.SizeOfPackages.ToList();
            var chargeOfPackage = _context.ChargeOfPackages.ToList();

            var viewModel = new PackageFormViewModel
            {
                
                SizeOfPackages = sizeOfPackage,
                ChargeOfPackages = chargeOfPackage
            };
            
            return View("PackagesForm",viewModel);
        }


        [Authorize(Roles = RoleName.CanManagePackages)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Package package)
        {

            if(!ModelState.IsValid)
            {
                var viewModel = new PackageFormViewModel(package)
                {
                    
                    SizeOfPackages = _context.SizeOfPackages.ToList(),
                    ChargeOfPackages = _context.ChargeOfPackages.ToList()
                    
                };

                return View("PackagesForm", viewModel);
            }

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



        [Authorize(Roles = RoleName.CanManagePackages)]
        public ActionResult Edit(int id)
        {
            var package = _context.Packages.SingleOrDefault(p => p.Id == id);

            if (package == null)
                return HttpNotFound();
            var viewModel = new PackageFormViewModel(package)
            {
                 
                SizeOfPackages = _context.SizeOfPackages.ToList(),
                ChargeOfPackages = _context.ChargeOfPackages.ToList()
            };

            return View("PackagesForm", viewModel);
          

        }
        


        
    }
}