using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public enum StatusType { Used, NotUsed, Canceled }
    public class OrderedCoupon
    {
        [Key]
        public int SerialNumId { get; set; }
        public string Opinion { get; set; }
        public int Rank { get; set; }
        public virtual DateTime UserDate { get; set; }
        public virtual StatusType Status { get; set; }
        public virtual Coupon DefinedBy { get; set; }
        public virtual Customer PurchesedBy { get; set; }
    }
}
