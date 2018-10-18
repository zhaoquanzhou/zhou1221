using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //const
    class A
    {
        //const又叫做编译时常量
        public int x;
        public const int y = 5;//常量const申明时必须赋值,常量本身是静态的,不能加static修饰符
        public void Test()
        {
            const float min = 60;
        }
    }
    //readonly 只读
    class B 
    {
        //运行时常量
        public readonly int x = 6;//可以在申明或构造函数中赋值
        public B()
        {
            x = 4;
        }

    }
}
