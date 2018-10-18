using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug特性作业
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    [GameBug("2018年10月17号", "赵")]
    class Person
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Mul(float a, int b)
        {
            return a * b;
        }
    }
}