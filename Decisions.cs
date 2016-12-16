using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Please select 1,2 or 3:");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You won a car!");
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You won a boat!");
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You won a cat!");
            }
            else
            {
                Console.WriteLine("I'm sorry, we didn't understand.");
            }
            Console.ReadLine();
            */
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Please select 1,2 or 3:");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.WriteLine("You won a " + message + ".");
            Console.WriteLine("You won a {0}.", message);//将｛0｝替换为message中的值
            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, message);//多个替换
            Console.ReadLine();
        }
    }
}
