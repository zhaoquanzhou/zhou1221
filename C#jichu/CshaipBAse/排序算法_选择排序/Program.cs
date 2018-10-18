using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 9, 5, 3, 0, 8 };
            for (int i = 0; i < arr.Length-1; i++)
            {
                //假设开始的位置为最小元素
                int min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    //找出最小元素的索引
                    if (arr[j]<arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
        
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            
        }
    }
}
