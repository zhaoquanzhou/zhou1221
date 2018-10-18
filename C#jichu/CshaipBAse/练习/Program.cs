using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Program
    {
        #region 方法练习
        static void Main1(string[] args)
        {
            int[] x = { 2, 8, 6, 4 };
            int max = Max(x);
            Console.WriteLine(max);
            int[] y = { 0, 2, 8, 0, 4 };           
            int[] ab=ToLeft(y);
            foreach (var item in ab)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            int[] z = { 2, 3, 2, 6, 7 };
            int a = 2;
            int b = 4;
            Replace(z,a,b);
            foreach (var item in z)
            {
                Console.Write(item + "\t");
            }


        }
        //2求数组最大元素值的2个方法,构成重载关系 ,支持int和float
        static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;

        }
        static float Max(float[] arr)
        {
            float max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;

        }

        //3.把数组非0元素向左靠齐的方法 比如 {0,2,8,0,4}靠齐后 {2,8,4,0,0}
        static void InDox(int[] arr)
        {
            
            for (int j = 0; j < arr.Length-1; j++)
{
                for (int i = 0; i < arr.Length-1-j; i++)
{
                    if (arr[i] ==0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

        }
        static int[] ToLeft(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int indox = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    arr1[indox] = arr[i];
                    indox++;
                }
            }
            return arr1;
        }

        //4,替换数组元素的方法 比如 {2,3,2,6,7}把2 替换成4
        static void Replace(int[] arr,int a, int b)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    arr[i] = b;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {

        }



    }
}
