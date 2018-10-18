using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组_一维数组
{
    class Program
    {
        //数组的定义
        static void Main1(string[] args)
        {
            //定义变量   数据类型   变量名
            //定义数组   数据类型[] 变量名

            
            int[] array;
            array = new int[3];//创建一个可以存储3个整数的数组对象,并赋值给array
            array[0] = 6;//为数组第0个元素赋值
            array[1] = 2;
            Console.WriteLine(array[0]);

            //数组定义2
            int[] array1 = new int[3] { 2,6,9};
            Console.WriteLine(array1[1]);
            //数组定义3
            int[] array2 = { 4,7,6};
            Console.WriteLine(array2[0]);
        }
        //数组的遍历
        static void Main2()
        {
            int[] arr = { 2,1,5,8,3};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            //数组的所有元素累加和
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        static void Main()
        {
            int sum = 0;
            int[] arr = { 4,6,1,3};
            foreach (var item in arr)
            {
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine(sum);
        }
    }
}
