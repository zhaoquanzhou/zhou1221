using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法_冒泡排序
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] arr = { 2,1,9,5,3,0,8};
            for (int j = 0; j < arr.Length-1; j++)//重复冒泡
            {
                //内层循环每循环一次就可以排出来一个最大的数到右边
                for (int i = 0; i < arr.Length - 1-j; i++)//-j是为了让已经排好的数不再参加比较
                {
                    if (arr[i] > arr[i + 1])//如果比后一个数大和后一个数交换位置
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1]=temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
           
        }
    }
}
