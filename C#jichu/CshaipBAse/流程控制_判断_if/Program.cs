using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_判断_if
{
    class Program
    {
        //单个条件if(){}
        static void Main1(string[] args)

        {
            Console.WriteLine("请输入成绩");
            float score = float.Parse(Console.ReadLine());
            if (score >= 60)
            {
                Console.WriteLine("及格");
            }
            else
            {
                Console.WriteLine("不及格");
            }
            
        }
        //多个条件if(){}
        static void Main(string[] args)
        {
            Console.WriteLine("请输入成绩");
            float score = float.Parse(Console.ReadLine());
            if (score>=90)
            {
                Console.WriteLine("优秀");
            }
            else if (score>=70)
            {
                Console.WriteLine("良好");
            }
            else if (score >= 60)
            {
                Console.WriteLine("及格");
            }
            else
            {
                Console.WriteLine("不及格");
            }

        }
    }
}
