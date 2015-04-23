using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponScanner
{
    public enum SourceType { Facebook, Twitter, GooglePlus }
    public class Recommendation
    {
        [Key]
        public int ID { get; set; }
        public SourceType Source { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public Customer Recommender { get; set; }
    }
}
