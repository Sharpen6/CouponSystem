using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public class Customer : User
    {
        public virtual List<Coupon> Purcheses { get; set; }
        public virtual List<IntrestsType> IntrestsIn { get; set; }
        public virtual List<Visit> BeenAt { get; set; }
        public virtual List<Recommendation> Recommends { get; set; }
        public virtual List<Customer> Friend { get; set; }
    }
}
