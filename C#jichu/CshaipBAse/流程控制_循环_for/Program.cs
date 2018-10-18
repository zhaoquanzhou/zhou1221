using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_循环_for
{
    class Program
    {

        static void Main1(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(i);
            }
        }
        //0-100累加
        static void Main2(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
           

        }
        //0-100所以偶数累加
        static void Main3(string[] args)
        {
            int sum1 = 0;
            for (int j = 0; j <= 100; j++)
            {
                if (j % 2 == 0)
                {
                    sum1 += j;
                }
            }
            Console.WriteLine(sum1);

        }
        //使用循环嵌套输出*
        static void Main4(string[] args)
        {

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        //百钱买百鸡
        static void Main5(string[] args)
        {
          
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 33; j++)
                {
                    for (int k = 0; k <= 300; k+=3)
                    {
                        if (i+j+k==100)
                        {
                            if (i*5+j*3+k/3==100)
                            {
                                Console.WriteLine($"公鸡:{i}母鸡{j}小鸡{k}");
                            }
                            
                        }
                       
                    }

                }

            }

        }
        //鸡兔同笼
        static void Main(string[] args)
        {
            for (int i = 0; i < 88; i++)
            {
                int k = 88 - i;
                if (2*i+4*k==244&&i+k==88)
                {
                    Console.WriteLine("鸡有{0}只兔有{1}",i,k);

                }
            }
        }
    }
}
