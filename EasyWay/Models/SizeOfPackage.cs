using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Models
{
    public class SizeOfPackage
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }  // Pithanon na mn xrhsimopoihthei katholou
        public short Pricing { get; set; }

    }
}