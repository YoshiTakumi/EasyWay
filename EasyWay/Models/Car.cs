using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyWay.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }
        

        [Display(Name = "Year Manufactured")]
        public DateTime? YearManufactured { get; set; }


        [Required]
        [Display(Name = "License Plate")]
        public string LicensePlate { get; set; }
    }
}