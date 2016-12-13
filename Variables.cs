using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            string fristName, lastName;
            Console.WriteLine("Please tell me you name");
            fristName = Console.ReadLine();
            lastName = Console.ReadLine();
            Console.WriteLine("Your name is " + fristName + " " + lastName);
        }
    }
}
