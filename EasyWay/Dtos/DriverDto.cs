using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyWay.Dtos
{
    public class DriverDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? Birthdate { get; set; }

        [Required]
        public long? Phone { get; set; }
    }
}