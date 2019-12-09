using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyWay.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }


        
        public DateTime? YearManufactured { get; set; }


        [Required]
        public string LicensePlate { get; set; }
    }
}