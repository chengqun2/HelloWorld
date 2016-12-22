using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];
            num[0] = 4;
            num[1] = 8;
            num[2] = 15;
            num[3] = 16;
            num[4] = 23;
            //Console.WriteLine(num[1]);
            Console.WriteLine(num.Length);
            */
            int[] num = new int[] { 4, 8, 15, 16, 23, 42 };
            string[] names = new string[] { "abc", "bcd", "cde", "def" };
            int[] nums = { 1, 2, 3, 4, 5 };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */
            /*
            foreach (var name in names)//遍历整个数组
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            //翻转整个数组
            string zig = "You can get what you want out of life if you help enough other people get what they want.";
            char[] charArray = zig.ToCharArray();//将字符串转变为字符数组
            Array.Reverse(charArray);//反转整个一维数组中元素的顺序
            foreach (char zigChar in charArray)//数组遍历
            {
                Console.Write(zigChar);
            }
            Console.WriteLine();
        }
    }
}
