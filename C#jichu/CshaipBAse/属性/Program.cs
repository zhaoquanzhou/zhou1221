using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("请输入你的年龄");
            person.Age = int.Parse(Console.ReadLine());
        }
    }
    class Person
    {
        private int age;//字段私有  //Ctrl+R+E 封装字段(做成属性)
        public int Age//属性公开
        {
            get
            {
                return age;
            }
            set
            {
                if (age<=0)
                {
                    Console.WriteLine("输入年龄不合法");
                }
                else
                {
                    age = value;
                }
                
            }
        }
    }
}
