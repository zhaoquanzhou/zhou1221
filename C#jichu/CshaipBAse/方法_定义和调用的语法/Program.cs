using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_定义和调用的语法
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = Add(5,8);

            Test(sum);
            int[] arr = { 2,5,7};
            Change(arr);
        }
        static void Test(string a)
        {
            Console.WriteLine(a);
        }
        static void Test(int a)
        {
            Console.WriteLine(a);
        }
        static void Test(float a)
        {
            Console.WriteLine(a);
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        //方法重载
        static float Add(float a, float b)
        {
            return a + b;
        }


        static int Min( int a,int b )
        {

            if (a>b)
            {
                return b;
            }
            else
            {
                return a;
            }

        }
        static int Jianfa(int a,int b)
        {
            return a - b;
        }
        static int Min(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Rank(int[] arr)
        {
            for (int j = 0; j < arr.Length-1; j++)
{
                for (int i = 0; i < arr.Length-1-j; i++)
{
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }            
        }
        static void Change(int[] arr)
        {
            arr[0] = 6;
        }

    }
}
