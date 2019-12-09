using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Dtos
{
    public class ChargeOfPackageDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int ChargeByRegion { get; set; }
    }
}