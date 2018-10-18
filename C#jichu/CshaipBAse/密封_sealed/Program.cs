using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封_sealed
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //sealed_不能被继承
    //sealed class A
    //{
    //}
    //class B:A不能继承
    //{
    //}
    class A
    {
        public virtual void Fun()
        {
        }
    }
    class B:A
    {
        //
        public sealed override void Fun()
        {
            base.Fun();
        }
    }
    class C:B
    {
        //无法重写 Fun
    }
}
