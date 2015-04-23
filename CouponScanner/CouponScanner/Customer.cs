using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public class Customer : User
    {
        public List<Coupon> Purcheses { get; set; }
        public List<IntrestsType> IntrestsIn { get; set; }
        public List<Visit> BeenAt { get; set; }
        public List<Recommendation> Recommends { get; set; }
        public List<Customer> Friend { get; set; }
    }
}
