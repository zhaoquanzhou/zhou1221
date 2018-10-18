using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 覆盖父类中的成员_new
{
    class Program
    {
        static void Main(string[] args)
        {
            A o = new B();
            Console.WriteLine(o.age);
            o.Test();

        }
    }
    class A
    {
        public int age = 5;
        public int age1 = 9;
        public void Test()
        {
            Console.WriteLine();
        }
    }
    class B:A
    {
        public new int age = 6;
        public new void Test()
        {
            Console.WriteLine(base.age);
            Console.WriteLine(this.age);
            Console.WriteLine("___________________");
            Console.WriteLine(base.age1);
            Console.WriteLine(this.age1);
        }
    }
}
