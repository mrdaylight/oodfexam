/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robertdonoghue_s00190029;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDetails db = new PhoneDetails();
            //Phone.PhoneDetails db = new Phone.PhoneDetails();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");


                //db.Phone.Add(p1);
                //db.Phone.Add(p2);
                
                //Console.WriteLine("Players added to database");
                db.SaveChanges();
                Console.WriteLine("Database saved");
            }
        }
    }
}
*/