using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 静态
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.a = 5;
            MyClass.b = 8;
            MyClass num = new MyClass();
            num.x = 6;
            MyClass.y = 4;
        }

    }
    class MyClass
    {
        public int a;//非静态 通过对象调用 每个对象各有一份
        public static int b;//静态 通过类名直接调用 只有一份
        public float x;
        public static float y;
    }
}
