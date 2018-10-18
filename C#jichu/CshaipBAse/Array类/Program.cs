using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array所有数组的父类
            int[] arr = { 2, 3, 5, 9, 0 };
            int[] arr1 = new int[10];
            //Array的静态方法
            //Array.Clear(); 清空数组元素
            //Array.Copy(); 复制元素到另外一个数组中
            Array.Copy(arr, arr1, 4);
            //Array.Sort(); 排序
            Array.Sort(arr);
            //Array.Reverse(); 反转
            Array.Reverse(arr);
            //Array.IndexOf(); 返回元素在数组中索引,如果不存在则返回-1;
            int i = Array.IndexOf(arr,9);
            Console.WriteLine(i);

            //CopyTo(); //复制           
            //Clone(); //克隆出来一个新数组
            // GetLength();//或取指定维度上得长度
            int[] a1 = new int[arr.GetLength(0)];
            arr.CopyTo(a1, 0);
            int[] ab = new int[arr.Length];
            ab = (int[])arr.Clone();//浅表副本
        }

    }
}
