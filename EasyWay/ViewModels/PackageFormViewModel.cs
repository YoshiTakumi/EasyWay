using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EasyWay.Models;

namespace EasyWay.ViewModels
{
    public class PackageFormViewModel
    {
        public IEnumerable<SizeOfPackage> SizeOfPackages { get; set; }
        public IEnumerable<ChargeOfPackage> ChargeOfPackages { get; set; }


        public int? Id { get; set; }

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



        [Display(Name = "Size")]
        [Required]
        public byte? SizeOfPackageId { get; set; }

        
        [Display(Name = "Region")]
        [Required]
        public byte? ChargeOfPackageId { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Package";
                return "New Package";
            }
        }



        public PackageFormViewModel()
        {
            Id = 0;
        }


        public PackageFormViewModel(Package package)
        {
            Id = package.Id;
            Sender = package.Sender;
            Receiver = package.Receiver;
            ReceiverAddress = package.ReceiverAddress;
            Phone = package.Phone;
            DateLeft = package.DateLeft;
            SerialNumber = package.SerialNumber;
            SizeOfPackageId = package.SizeOfPackageId;
            ChargeOfPackageId = package.ChargeOfPackageId;
        }


    }
}