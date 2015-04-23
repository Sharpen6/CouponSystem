using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponScanner
{
    class Coupon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double OriginalPrice { get; set; }
        public double DiscountPrice { get; set; }
        public DateTime ExperationDate { get; set; }
        public double AvarageRanking { get; set; }
    }
}
