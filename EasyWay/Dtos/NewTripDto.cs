using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Dtos
{
    public class NewTripDto
    {
        public int DriverId { get; set; }

        public int CarId { get; set; }

        public List<int> PackageIds { get; set; }
    }
}