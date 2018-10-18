using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数调用过程调用父类构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class A
    {
        public int a;
        public A(int a)
        {
            this.a = a;  
        }
        public A()
        {

        }
    }
    class B:A
    {
        public int b;
        //public B(int a,int b):base(a)//如果不使用:base() 则默认调用父类中公共无参的构造函数
        //{
        //    this.b = b;
        //}
        public B(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
