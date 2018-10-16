using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5,3,4,9,0,6,1};
            MyQueueT<int> queueT = new MyQueueT<int>();
            queueT.Puch(23);
            queueT.Puch(2);
            queueT.Puch(53);
            queueT.Puch(13);
            int a = queueT.Pop();
            Console.WriteLine(a);
            Scort(arr);
           
        }
        //实现排序方法:能对任意可比较类型
        public static void Scort<T>(T[] arr) where T:IComparable
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j =i+1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        T tamp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tamp;
                    }
                }
            }
        }

    }
    class MyStackT<T>
    {
        List<T> stack = new List<T>();

        /// <summary>
        /// 出栈
        /// </summary>
        public T Pop()
        {
            if (stack.Count <= 0)
            {
                throw new Exception("栈空了");
            }
            T result = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return result;
        }

        /// <summary>
        /// 进栈
        /// </summary>
        public void Puth(T value)
        {
            stack.Add(value);
        }
    }
    class MyQueueT<T> where T : IComparable //泛型约束 1/接口约束 2/基类约束
    {
        List<T> queue = new List<T>();
        public T Pop()
        {
            if (queue.Count <= 0)
            {
                throw new Exception("队列空了");
            }
            T reatule = queue[0];
            queue.RemoveAt(0);
            return reatule;
        }
        public void Puch(T value)
        {
            queue.Add(value);
        }

    }
    class Npc : IComparable
    {
        public int hp;
        public Npc(int _hp)
        {
            hp = _hp;
        }
        public int CompareTo(object obj)
        {
            Npc n = obj as Npc;
            if (n == null)
            {
                throw new Exception("传入参数错误");
            }
            return hp.CompareTo(n.hp);
        }
    }
    



}
