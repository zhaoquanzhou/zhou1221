#define abc

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 特性
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //OldFun();
            NewFun();
        }

        [Obsolete("这个方法已过时,请使用新方法", true)]
        public static void OldFun()
        {
            Console.WriteLine("这是一个老方法");
        }

        [Conditional("abc")]//条件方法特性 需要宏定义条件才会执行方法体的代码
        public static void NewFun()
        {
            Console.WriteLine("这是一个新方法");
        }
    }
}