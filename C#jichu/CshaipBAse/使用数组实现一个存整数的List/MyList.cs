using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用数组实现一个存整数的List
{
    class MyList
    {
        //容器
        private int[] arr = new int[4];
        //容器大小
        public int Capacity { get { return arr.Length; } }
        //元素个数
        public int Count { get; set; }
        //添加
        public void Add(int item)
        {
            //保证容器够用
            if (Count==Capacity)
            {
                int[] newArr = new int[Capacity*2];//
                arr.CopyTo(newArr,0);//
                arr = newArr;//
            }
            //放新元素
            arr[Count] = item;
            Count++;
        }
        //根据索引移除
        public void RemoveAt(int Index)
        {
            for (int i = Index; i < Count-1; i++)
            {
                arr[i] =arr[i+1];
            }
            Count--;
        }
        //是否包含
        public bool Contain(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (arr[i]==item)
                {
                    return true;
                }
            }
            return false;
        }
        //插入元素

        //添加索引器
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value;}
        }
    }
}
