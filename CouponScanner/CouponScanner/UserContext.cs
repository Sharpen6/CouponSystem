using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponScanner
{
    public class UserContext : DbContext
    {
        public DbSet<User> Coupons { get; set; }
    } 
}
