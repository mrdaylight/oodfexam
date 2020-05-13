using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace robertdonoghue_s00190029
{
    public class Phone
    {
        // q2
        public string Name { get; set; }
        public double Price { get; set; }
        public string Operating_System { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        public virtual int ID { get; set; }

        // q3
        public void IncreasePrice(double percentIn)
        {
            this.Price = this.Price + (this.Price * (percentIn / 100));
        }

        


        //contructors
        public Phone(string nameIn, double priceIn, string osIn, string imageIn, string pImageIn)
        {
            this.Name = nameIn;
            this.Price = priceIn;
            this.Operating_System = osIn;
            this.OS_Image = imageIn;
            this.Phone_Image = pImageIn;
        }

        public override string ToString()
        {
            return this.Price.ToString();
        }

        public Phone()
        {

        }
    }
    public class PhoneDetails : DbContext
    {
        public PhoneDetails() : base("PhoneDetails") { }

        public DbSet<Phone> Phone { get; set; }
    }

}
