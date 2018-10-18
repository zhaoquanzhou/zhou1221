using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型转换
{
    class Program
    {
        //隐式转换
        static void Main1(string[] args)
        {
            int a = 5;
            float b = a;//低取值范围到高取值范围的转换
            byte c = 5;
            int d = c;
        }
        //强制转换
        static void Main2(string[] args)
        {
            float f = 5.56f;
            int i = (int)f;
            Console.WriteLine(i);//浮点数转整数丢失小数

            int a = 256;
            byte b = (byte)a;
            Console.WriteLine(b);
        }
        //Convert转换
        static void Main3(string[] args)
        {
            int a = 255;
            byte b = Convert.ToByte(a);
            Console.WriteLine(b);

            float f = 1.05f;
            int i= Convert.ToInt32(f);
            Console.WriteLine(i);
        }
        //Parse转换
        static void Main(string[] args)
        {
           // Console.WriteLine("请输入第一个数字");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("请输入第二个数字");
           // string s2 = Console.ReadLine();
           // int sum = int.Parse(s1) + int.Parse(s2);
            //Console.WriteLine(sum);


            string str = "86";
            int i = int.Parse(str);
            byte u = byte.Parse(str);
            float o = float.Parse(str);

            Console.WriteLine(i);
            Console.WriteLine(u);
            Console.WriteLine(o);
            //要求字符串类型相同
            

        }
    }
}
