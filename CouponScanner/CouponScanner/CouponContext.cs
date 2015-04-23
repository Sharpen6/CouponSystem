using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponScanner
{
    public class CouponContext : DbContext
    {
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<OrderedCoupon> OrderedCoupons { get; set; }
    } 
}
