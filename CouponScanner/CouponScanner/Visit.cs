﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public class Visit
    {
        [Key]
        public int ID { get; set; }
        public virtual List<Location> Coordinates { get; set; }
    }
}
