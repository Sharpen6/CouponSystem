using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Run();

        }

        private void Run()
        {
            using (var db = new CouponContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var coupon = new Coupon { ID=3, Name = name };
                db.Coupons.Add(coupon);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Coupons
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 

        }
    }

}
