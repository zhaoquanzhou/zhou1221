using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListHamework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(7);
            list.Add(1);
            list.Add(4);
            list.Add(6);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.WriteLine();
            int b = list[3];
            Console.WriteLine(b);
            Console.WriteLine();
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.WriteLine();
            list.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
        }
    }



    class MyList<T>
    {
        //list的变量
        private T[] arr;//容器
        private int capcity;//容量
        private int count;//最大容量
        //最大容量属性
        public int Count { get => count; set => count = value; }
        //初始容量
        public MyList()
        {
            count = 0;
            capcity = 4;
            arr = new T[capcity];
        }
        public MyList(int capcity)
        {
            if (capcity <= 0)
            {
                this.capcity = 4;
            }
            else
            {
                this.capcity = capcity;
            }
            count = 0;
            arr = new T[capcity];
        }
        //扩充容量
        private void ExpandedCapacity()
        {
            if (count == capcity)
            {
                int length = capcity * 2;
                T[] newArr = new T[length];
                Array.Copy(arr, newArr, capcity);
                capcity = length;
                arr = newArr;
            }
        }
        //索引器
        public T this[int index]
        {
            get
            {
                IndexOutOfRange(index);
                return arr[index];
            }
            set
            {
                IndexOutOfRange(index);
                arr[index] = value;
            }
        }
        //根据索引器查找元素
        public T GetIndexOfItem(int index)
        {
            IndexOutOfRange(index);
            return arr[index];
          
        }
        //根据索引器查找元素的索引
        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        //添加
        public void Add(T item)
        {
            if (item == null)
            {
                Console.WriteLine("添加元素为空");
                return;
            }
            ExpandedCapacity();
            arr[count] = item; ;
            count++;
        }
        //反转
        public void Reverse()
        {
            Array.Reverse(arr, 0, count);
            #region reverse
            //IndexOutOfRange(count);
            //for (int i = 0; i < count; i++)
            //{
            //    for (int j = count - 1; j >= 0; j--)
            //    {
            //        if (i == j)
            //        {
            //            arr[i] = arr[j];
            //        }
            //        T temp = arr[i];
            //        arr[i] = arr[j];
            //        arr[j] = temp;
            //    }
            //}
            #endregion

        }
        
        //全部清除
        public void Clear()
        {
            Array.Clear(arr, 0, count);
            //for (int i = 0; i < count; i++)
            //{
            //    arr[i] = default(T);
            //}
            //this.count = 0;
        }
        //判断索引是否索引范围
        private void IndexOutOfRange(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new Exception("索引超出范围了");
            }
        }
        //根据索引移除索引元素
        public void RemoveAt(int index)
        {

            for (int i = index; i < count - 1; i++)
            {
                arr[index] = arr[index + 1];
            }
            count--;
            arr[count] = default(T);
        }
        //根据内容移除列表里与内容相同的部分
        public bool Remove(T item)
        {
            if (item == null)
            {
                Console.WriteLine("传入参数为空");
                return false;
            }
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(arr[i]))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        // 从索引开始复制列表
        public void CopyTo(T[] newArr, int newArrIndex)
        {
            IndexOutOfRange(newArrIndex);
            newArr = new T[count - newArrIndex];
            int j = 0;
            for (int i = newArrIndex; i < count; i++)
            {

                newArr[j] = arr[i];
                j++;
            }
        }
        
    }
}
