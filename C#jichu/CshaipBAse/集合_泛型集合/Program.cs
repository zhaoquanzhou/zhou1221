using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合_泛型集合
{
    class Program
    {
        //List<T>列表 顺序存储
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();//创建list对象
            //添加元素
            list.Add(22);
            list.Add(32);
            //访问元素
            list[0] = 15;
            Console.WriteLine(list[0]);
            Console.WriteLine("___________________");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("___________________");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //list的API
            int[] arr = { 5,6,3,2,2};
            list.AddRange(arr);//添加一个数组 参数是数组 ,或其他可迭代对象
            //list.Capacity 容器大小
            //list.Clear();//清除
            //ist.RemoveAt();//从某个位置元素,移除性能消耗比较高,会重新设置后面索引
            //list.ToArray();转成数组,原来的list还在
        }
        //Dictonary<T>字典 键值对存储
        static void Main2(string[] args)
        {
            //姓名,电话
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //添加元素
            dic.Add("小名","64635533");
            dic.Add("小黑","46646467");
            dic.Add("下班","44564676");
            dic.Add("馒头","64566456");
            //获取数据
            Console.WriteLine(dic["下班"]);
            //访问
            Console.WriteLine(dic["馒头"]);
            //遍历只能用foreach
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }
            Console.WriteLine("_________________");
            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(dic[item]);
            }
            Console.WriteLine("_________________");
            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }
            //dictionary的API
            //dic.ContainsKey();//是否某个键 返回bool值
            //dic.Remove("张三");移除
            //dic.TryGetValue("张三",out phoneNo);
        }
        //Stack<T>栈 先进后出
        static void Main3(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //进栈
            stack.Push(2);
            stack.Push(5);
            stack.Push(9);
            //出栈
            //Console.WriteLine(stack.Peek());//返回元素但不移除
            Console.WriteLine(stack.Pop());//输出栈 并移除
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        //Queue<T>队列 先进先出
        static void Main(string[] args)
        {
            Queue<int> que = new Queue<int>();
            que.Enqueue(2);//进队
            que.Enqueue(6);//进队
            que.Enqueue(7);//进队
            //que.Peek();//只返回队列元素 不移除
            while (que.Count>0)
            {
                Console.WriteLine(que.Dequeue());//出队
            }
        }
    }
}
