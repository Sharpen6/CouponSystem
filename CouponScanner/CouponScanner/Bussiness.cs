using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public enum CategoryType { Restaurant, Trips, Entertainment, Clothes }
    public class Bussiness
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location {get;set;}
        public virtual List<Coupon> Sells { get; set; }
        public virtual BussinessOwner OwnedBy { get; set; }
        public virtual Admin CreatedBy { get; set; }
        public virtual List<CategoryType> BussinessType { get; set; }
    }
}
