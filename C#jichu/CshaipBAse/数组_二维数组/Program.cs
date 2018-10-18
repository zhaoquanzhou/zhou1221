using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组_二维数组
{
    class Program
    {
        //二维数组的定义
        static void Main(string[] args)
        {
            //int[,] arr = new int[4,3];
            //arr[0, 1] = 5;
            //arr[2, 2] = 7;
            int[,] arr = //new int[4, 3]
            {
                {0,0,7},
                {5,0,2},
                {0,6,0},
                {0,8,0}
            };
            //遍历
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write(arr[r,c]+"\t");//\t为Tab键,制表符
                }
                Console.WriteLine();
            }
            
        }
    }
}
