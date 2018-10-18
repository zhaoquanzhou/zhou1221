using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            
        }
    }
    public class A
    {
        public int pub;//公开的 在哪里都可以访问
        private int pri;//私有的 只能在本类内部访问 类成员的访问修饰符
        protected int pro;//受保护的  只能在本类和子类内部访问
        internal int inter;//程序集内部的_只能在同一个程序集访问 类的访问修饰符
        void Test()
        {
            

        }
    }
    class B:A
    {
        void Fun()
        {
            pro = 3;
            Console.WriteLine(pro);
        }
    }
    class C:B
    {
        
    }
}
