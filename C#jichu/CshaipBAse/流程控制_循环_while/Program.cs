using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_循环_while
{
    class Program
    {
        static void Main1(string[] args)
        {
            int sum = 0;
            int i = 0;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            float hight = 10000f;
            int tims = 0;
            while (hight * 0.75f > 0.5f)
            {
                hight *= 0.75f;
                tims++;
            }
            Console.WriteLine(tims);
        }
        
    }
}
