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
        public int Phone { get; set; }
    }
}