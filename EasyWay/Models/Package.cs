using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string ReceiverAddress { get; set; }
        public int SerialNumber { get; set; }
        public DateTime DateLeft { get; set; }
        public long Phone { get; set; }
        public bool Delivered { get; set; }

        public SizeOfPackage SizeOfPackage { get; set; }
        public byte SizeOfPackageId { get; set; }

        public ChargeOfPackage ChargeOfPackage { get; set; }
        public byte ChargeOfPackageId { get; set; }

        public int FinalPrice { get; set; }
    }
}