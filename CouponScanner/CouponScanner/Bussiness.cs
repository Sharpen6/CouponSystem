using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    enum CategoryType {Restaurant,Trips,Entertainment,Clothes}
    class Bussiness
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location {get;set;}
        public List<Coupon> Sells { get; set; }
        public BussinessOwner OwnedBy { get; set; }
        public Admin CreatedBy { get; set; }
        public List<CategoryType> BussinessType { get; set; }
    }
}
