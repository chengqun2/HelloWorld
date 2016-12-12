using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            string b = "\"a\"";//输出双引号
            Console.WriteLine("HelloWorld!");
            Console.Write("HelloWorld!\n");//writeline输出自动换行
            Console.Write("The value " + b + " is " + a + "\n");//输出变量
            Console.ReadLine();//读取一个换行
        }
    }
}
