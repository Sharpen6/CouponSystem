using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    class testContext :DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
