using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_判断_switch
{
    class Program
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("欢迎致电10086,话费查询请按1,宽带办理请按2 ,人工服务请按0");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("你的电话已欠费");
                    break;
                case "2":
                    Console.WriteLine("已经帮你预约安装师傅");
                    break;
                case "0":
                    Console.WriteLine("转接中,请稍后...");
                    break;
                default://都不是
                    Console.WriteLine("对不起,没有这个选项");
                    break;
            }
        }
        static void Main(string[] args)
        {
            //贯穿
            Console.WriteLine("请输入星期几");
            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("上课");
                    break;
                case "6":
                    Console.WriteLine("自习");
                    break;
                case "7":
                    Console.WriteLine( "休息");
                    break;

                default:
                    break;
            }
        }
    }
}
