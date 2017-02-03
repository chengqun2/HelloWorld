using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.Month);
            DateTime myDateTime = new DateTime(1990,1,1);
            Console.WriteLine(myDateTime.ToShortDateString());
            myDateTime = DateTime.Parse("1995/10/25");
            Console.WriteLine(myDateTime);
            TimeSpan myAge = DateTime.Now.Subtract(myDateTime);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
