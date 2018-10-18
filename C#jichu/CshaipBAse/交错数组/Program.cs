using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 交错数组
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[][] arr = new int[2][];
            //arr[0] = new int[3];
            //arr[1] = new int[2];
            //arr[0][1] = 6;
            //arr[0][2]= 7;
            //arr[1][1] = 8;
            //arr[0][0] = 9;
            //Console.WriteLine(arr[0][1]);

            int[][] arr =
            {
              new int[] {2,8 },
              new int[] {4,6,8}
            };
            //遍历
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+"\t");

                }
                Console.WriteLine();
            }
        }
    }
}
