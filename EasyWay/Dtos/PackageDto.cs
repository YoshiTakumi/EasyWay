using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyWay.Dtos
{
    public class PackageDto
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
        public string ReceiverAddress { get; set; }


        [Required]
        public int? SerialNumber { get; set; }

        [Required]
        public DateTime? DateLeft { get; set; }

        [Required]
        public long? Phone { get; set; }


        public bool Delivered { get; set; }


        public SizeOfPackageDto SizeOfPackage { get; set; }  


        public byte SizeOfPackageId { get; set; }

        public ChargeOfPackageDto ChargeOfPackage { get; set; } 


        
        public byte ChargeOfPackageId { get; set; }


    }
}