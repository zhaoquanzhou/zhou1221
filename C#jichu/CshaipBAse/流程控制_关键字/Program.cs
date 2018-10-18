using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_关键字
{
    class Program
    {
        //continue
        static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        //break 
        static void Main2(string[] args)
        {
            // for (int i = 0; i < 10; i++)
            //{
            // if (5==0)
            // {
            //break;
            // }
            // Console.WriteLine(i);
            // }
            int sum = 0;
            int i = 0;
            while (true)
            {
                sum += i;
                i++;
                if (sum > 20000)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        static void Main3(string[] args)
        {

            Console.WriteLine("请输入0-100的数字:");

           
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0 || num > 100)
                {
                    Console.WriteLine("输入数字不合法,请重新输入,数字范围0-100:");
                    break;
                }
                Console.WriteLine("OK");
                return;

            }
        }
        //return
        static void Main3()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    return;
                }

            }
            Console.WriteLine();
        }
        //goto 大部分禁止使用
        static void Main4()
        {
            Console.WriteLine(123);
            a:;
            Console.WriteLine(456);
            Console.WriteLine(789);
            goto a;
        }
    }
}
