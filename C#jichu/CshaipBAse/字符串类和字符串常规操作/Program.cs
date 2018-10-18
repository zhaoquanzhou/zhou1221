using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//正则表达式的命名空间

namespace 字符串类和字符串常规操作
{
    class Program
    {
        //转义符
        static void Main1(string[] args)
        {
            Console.WriteLine("姓名\t班级\t学号");
            Console.WriteLine("AA\r\nBB\r\nCC\r\n");
            Console.WriteLine("AA\0BB");
            Console.WriteLine("\a 报警符");
            Console.WriteLine("他说:\"今天天气很好\"");
        }
        //正则表达式
        static void Main2(string[] args)
        {
            //邮箱的正则表达式对象
            Regex rex = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");
            while (true)
            {
                Console.WriteLine("请输入邮箱:");
                //读取用户的输入,判断是否是邮箱
                string input = Console.ReadLine();
                if (rex.IsMatch(input))
                {
                    Console.WriteLine("邮箱格式正确,注册成功");
                }
                else
                {
                    Console.WriteLine("邮箱格式不正确");
                }
            }

        }
        //StringBuilder
        static void Main(string[] args)
        {

            string s1 = "A";
            string s2 = "B";
            string s3 = "C";
            string s4 = "D";
            string str = s1 + s2 + s3 + s4;//相加产生垃圾
            //字符串频繁相加应该使用StringBuilder以节省内存
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                sb.Append(i);             
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
