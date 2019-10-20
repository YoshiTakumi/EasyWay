using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyWay.Models;
using EasyWay.ViewModels;

namespace EasyWay.Controllers
{
    public class PackagesController : Controller
    {
        // GET: Packages
        public ViewResult Index()
        {
            var packages = GetPackages();

           
            return View(packages);
        }

        


        private IEnumerable<Package> GetPackages()
        {
            return new List<Package>
            {
                new Package { Id = 1 , Sender = "Γιάννης Χατζηπαύλου", Receiver = "Γεώργιος Λεβεντόπουλος",
                                ReceiverAddress = "Καρατάσου 1", SerialNumber = 1241 },

                new Package { Id = 2 , Sender = "Tony Montana", Receiver = "Hector Salamanca",
                                ReceiverAddress = "Medellin 12", SerialNumber = 1243}
            };

            
        }
    }
}