using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public string Coordinates;
    }
}
