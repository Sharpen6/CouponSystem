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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new testContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = textBox1.Text;

                var coupon = new User { ID = 3, Name = name, EMail="asdasd",PhoneNumber=234,Password="sdsa" };
                db.Users.Add(coupon);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Users
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    textBox2.Text+=item.Password+"\n";
                }
            } 
        }
    }

}
