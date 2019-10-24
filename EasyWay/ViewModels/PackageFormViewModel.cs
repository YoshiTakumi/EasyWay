using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyWay.Models;

namespace EasyWay.ViewModels
{
    public class PackageFormViewModel
    {
        public IEnumerable<SizeOfPackage> SizeOfPackages { get; set; }
        public IEnumerable<ChargeOfPackage> ChargeOfPackages { get; set; }
        public Package Package { get; set; }
    }
}