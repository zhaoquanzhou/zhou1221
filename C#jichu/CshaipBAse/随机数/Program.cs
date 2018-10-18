using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            while (true)
            {
                Console.ReadLine();
                int num = ran.Next(0, 3);//取不到右端点
                Console.WriteLine(num);
            }
        }
        static void Main()
        {
            Random ran = new Random();
            int num = ran.Next(0, 101);
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input>num)
                {
                    Console.WriteLine("大了");

                }
                else if (input<num)
                {
                    Console.WriteLine("小了");
                }
                else
                {
                    Console.WriteLine("恭喜你,选对了");
                }
            }


        }
    }
}
