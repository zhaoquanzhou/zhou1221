using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托和事件
{
    public delegate void Behaver();

    public delegate int Intmath(int a);

    public delegate int Calculate(int a, int b);

    internal class Program
    {
        private static void Main(string[] args)
        {
            SayHello say = new SayHello();
            say.SayHelloLanguage(ByEnglish);
            Calculate calculate = new Calculate(Add);
            //calculate += Sub;
            //calculate += Ride;
            //calculate += Divide;
            //calculate(5, 6);
            //calculate -= Ride;
            //calculate(42, 12);
            //calculate = Sub;
            //calculate(23, 12);
            //匿名方法
            say.SayHelloLanguage(delegate () { Console.WriteLine("你好!111"); });
            //Lambda表达式
            say.SayHelloLanguage(() => { Console.WriteLine("大家好"); });

            calculate = (int a, int b) => { Console.WriteLine(a + b); return a + b; };
            calculate = (int a, int b) => { Console.WriteLine(a * b); return a * b; };
            calculate(12, 6);
            Intmath intmath = a => a + 1;
            calculate = (a, b) => a > b ? a : b;
            int sum = calculate(6, 7);
            Console.WriteLine(sum);
        }

        #region 方法

        private static void ByEnglish()
        {
            Console.WriteLine("Hello,Nice to me to");
        }

        private static int Add(int a, int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            return a + b;
        }

        private static int Sub(int a, int b)
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            return a - b;
        }

        private static int Ride(int a, int b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            return a * b;
        }

        private static int Divide(int a, int b)
        {
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            return a / b;
        }

        #endregion 方法
    }

    internal class MySingle
    {
        private MySingle instence;

        public MySingle Instence
        {
            get
            {
                instence = new MySingle();
                return instence;
            }
        }
    }

    internal class SayHello
    {
        public void SayHelloLanguage(Behaver behaver)
        {
            Console.WriteLine("开始打招呼");
            behaver();
        }
    }
}