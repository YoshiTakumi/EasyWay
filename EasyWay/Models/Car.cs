using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public DateTime? YearManufactured { get; set; }
        public string LicensePlate { get; set; }
    }
}