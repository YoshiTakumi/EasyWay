using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyWay.Models;

namespace EasyWay.ViewModels
{
    public class TripViewModel
    {
        public List<Package> Packages { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Car> Cars { get; set; }
    }
}