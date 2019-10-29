using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Models
{
    public class Package
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Sender { get; set; }

        [Required]
        [StringLength(255)]
        public string Receiver { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Address")]
        public string ReceiverAddress { get; set; }


        [Required]
        [Display(Name = "Serial Number")]
        public int? SerialNumber { get; set; }

        [Required]
        [Display(Name = "Delivery date")]
        public DateTime? DateLeft { get; set; }

        [Required]
        public long? Phone { get; set; }


        public bool Delivered { get; set; }

       
        public SizeOfPackage SizeOfPackage { get; set; }



        [Display(Name = "Size")]
        public byte SizeOfPackageId { get; set; }

        public ChargeOfPackage ChargeOfPackage { get; set; }


        [Display(Name = "Region")]
        public byte ChargeOfPackageId { get; set; }

        public int FinalPrice { get; set; }
    }
}