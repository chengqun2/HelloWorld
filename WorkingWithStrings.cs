using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life.";//双引号
            //string myString = "What if I need a\nnew line?";//换行
            //string myString = "Go to your c:// driver";
            //string myString = @"Go to your c:/ driver";//反斜杠
            //string myString = String.Format({0}={1},"First","Second");
            //string myString = string.Format("{0:C}",123.45);//:C代表货币格式化
            //string myString = string.Format("{0:N}",1234567890);//:N为大数添加逗号和小数点
            //string myString = string.Format("{0:P}", .123);//把小数以百分号的形式输出
            //string myString = string.Format("Phone Number:{0:(###) ###-####}",1234567890);//自定义显示方式
            
            //string myString = " That summer we took threes across the board  ";
            //myString = myString.Substring(6,14);//输出字符串中第6到第14位置中的字符
            //myString = myString.ToUpper();//转换为大写字母
            //myString = myString.Replace(" ","--");//替换字符，后者替换前者
            //myString = myString.Remove(6,14);//删除第六到第十四位置的字符
            //myString = string.Format("Length before:{0} -- Length after{1}",myString.Length,myString.Trim().Length)//有空格长度和去掉空格后的长度
            
           
            StringBuilder myString = new StringBuilder();
            for(int i =0;i<100;i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            
            
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
