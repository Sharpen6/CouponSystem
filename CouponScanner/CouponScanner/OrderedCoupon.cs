using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    enum StatusType { Used, NotUsed, Canceled }
    class OrderedCoupon
    {
        public int SerialNum { get; set; }
        public string Opinion { get; set; }
        public int Rank { get; set; }
        public DateTime UserDate { get; set; }
        public StatusType Status { get; set; }
        public Coupon DefinedBy { get; set; } 
    }
}
