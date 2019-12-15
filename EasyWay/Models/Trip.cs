using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyWay.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public Package Package { get; set; }



        [Required]
        public Driver Driver { get; set; }



        [Required]
        public Car Car { get; set; }

        [Required]
        public DateTime DateLeftTheStore { get; set; }



    }
}