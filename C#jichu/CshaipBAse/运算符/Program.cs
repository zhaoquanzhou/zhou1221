using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符
{
    class Program
    {
        //算数运算符
        static void Main1(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine(a + b);
            string s1 = "A";
            string s2 = "B";
            Console.WriteLine(s1 + s2);

            //++
            int x = 1;
            Console.WriteLine(x++);
            Console.WriteLine(x);


            int i = 5;
            int i1 = 1 + --i;
            Console.WriteLine(i1);

            //%
            Console.WriteLine(10 % 3);
        }
        //关系运算符
        static void Main2(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 5;
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a >= b);
            Console.WriteLine(c != b);
        }
        //赋值运算符
        static void Main3(string[] args)
        {
            //=
            int a = 5;
            string s = Console.ReadLine();
            //+=
            a += 2;//a = a + 2;
            Console.WriteLine(a);
            //-=
            int x = 6;
            x -= 3;
            Console.WriteLine(x);
            //*=

            int i = 5;
            int j = i;


        }
        //逻辑运算符
        static void Main4(string[] args)
        {
            //&&与
            Console.WriteLine(7 > 6 && 10 > 11);
            //||或
            Console.WriteLine(7 > 6 || 4 > 8);
            //!非
            Console.WriteLine(!(7 > 6));

        }
        //位运算符
        static void Main5(string[] args)
        {
            byte a = 3;
            byte b = 5;
            byte c = 1;
            //&
            Console.WriteLine(a & b);
            //|
            Console.WriteLine(a | b);
            //~
            byte d = (byte)~c;
            Console.WriteLine(d);
            //^异或两个不同则为1
            Console.WriteLine(a ^ b);
            //<<左移
            Console.WriteLine(a << 2);
            //>>右移 如果有符号位则空位补符号 负数补1 正数补0
            Console.WriteLine(c >> 5);
        }
        //三元运算符?:
        static void Main6(string[] args)
        {
            //条件?条件成立的结果:条件不成立的结果
            //int a = 8, b = 6;
            //int c = a > b ? 1 : 0;
            // Console.WriteLine(c);
            Console.WriteLine("请输入成绩");
            int score = int.Parse(Console.ReadLine());
            string s = score >= 60 ? "及格" : "不及格";
            Console.WriteLine(s);


        }
        //三元运算符?:的嵌套
        static void Main7(string[] args)
        {
            Console.WriteLine("请输入成绩");
            int score = int.Parse(Console.ReadLine());
            string s =
                score >= 90 ? "优秀" :
                score >= 70 ? "良好" :
                score >= 60 ? "及格" :
                "不及格";
            Console.WriteLine(s);


        }
       
    }
}
