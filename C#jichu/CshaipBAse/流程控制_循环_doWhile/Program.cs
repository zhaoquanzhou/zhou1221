using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 流程控制_循环_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入0-100之间的数字,如果数字不合法就让用户重新输入,直到正确
            string msg = "请输入0-100之间的数字";
            int i;
            do
            {
                Console.WriteLine(msg);
                i = int.Parse(Console.ReadLine());
                msg = "输入数字不合法,请重新输入,数字范围在0-100";

            } while (i < 0 || i > 100);
            Console.WriteLine("OK");
            
        }
    }
}
