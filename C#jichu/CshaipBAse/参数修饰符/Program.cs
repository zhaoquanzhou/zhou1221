using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数修饰符
{
    class Program
    {
        //ref 引用参数传递前必须赋值
        static void Main1(string[] args)
        {
            int x = 4;
            Change(ref x);//ref传递的是变量本身的内存地址
            Console.WriteLine(x);
        }
        static void Change(ref int a)
        {
            a = 9;

        }

        //out 输出参数方法返回前必须赋值
        static void Main2(string[] args)
        {
            int x;//进方法前准备一个容器,接受方法输出的结果,out一般用在方法有多个返回值的情况
            Change1(out x);
            Console.WriteLine(x);
        }
        static void Change1(out int a)
        {
            a = 6;
        }

        //TtyParse
        static void Main3(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个整数");
                int i;
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine("您输入的是:" + i);
                }
                else
                {
                    Console.WriteLine("您输入的不是数字");
                }
            }
        }

        //做一个交换两个变量的方法
        static void Main4(string[] args)
        {
            int x = 18;
            int y = 6;

            ExChange(ref x, ref y);
            Console.WriteLine("x是{0},y是{1}", x, y);

        }

        static void ExChange(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //params
        static void Main()
        {
            GetSum(4,5,6);
        }

        //求n个整数的和的方法
        static int GetSum(params int[] arr)//params只作为最后一个参数出现
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
