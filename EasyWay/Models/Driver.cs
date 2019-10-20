using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyWay.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public long Phone { get; set; }
    }
}