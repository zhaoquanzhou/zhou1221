using System;
using System.Collections;//非泛型
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合_非泛型集合
{
    class Program
    {
        //Arraylist 数组列表        
        static void Main1(string[] args)
        {
            ArrayList list = new ArrayList(); //创建ArrayList对象
            list.Add(5);
            list.Add(6);
            list.Add("ABC");//可以同时存储多种数据类型
            list.Add(new int[] { 2,5,6});
            int sum = (int)list[0] + (int)list[1];//使用的时候需要转成具体类型,性能比泛型集合低,值类型转换会发生装箱和拆箱操作
        }
        //HashTable 哈希表
        static void Main2(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("name","张三");
            table.Add("age","16");
            table.Add("x", "10");
            table.Add("y", "26");
            Console.WriteLine(table["name"]);
            int i= (int)table["x"]+(int)table["y"];
        }
        //Stack
        static void Main3(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(6);
            stack.Push(9);
            stack.Push("张三");

            Console.WriteLine(stack.Pop()); 
        }
        //Queue
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("学习");
            queue.Enqueue("45");
            queue.Enqueue("asdad");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("主机", "192.168.2.254");
            dic.Add("用户名", "the9");
            dic.Add("密码", "admin");
            dic.Add("端口", "21");
            Console.WriteLine(dic["主机"]);//获取数据
            dic["主机"] = "192.198.1.254";//修改数据
            //遍历
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key );
                Console.WriteLine(item.Value);
            }

        }
    }
}
