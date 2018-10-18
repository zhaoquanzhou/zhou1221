using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 占位符
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请用户输入");
            Console.WriteLine("学生姓名");
            string name = Console.ReadLine();
            Console.WriteLine("学号");
            string a = Console.ReadLine();
            Console.WriteLine("成绩");
            string b = Console.ReadLine();
            int c = int.Parse(a);
            float d = float.Parse(b);
            //传统占位符
            //Console.WriteLine("{0}的学号是{1}成绩是{2}分",name,c ,d );
            Console.WriteLine($"{name}的学号是{a}成绩是{b}分");
        }
    }
}
