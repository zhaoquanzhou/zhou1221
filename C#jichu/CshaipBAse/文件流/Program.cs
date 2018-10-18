using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件流
{
    class Program
    {
        //读取
        static void Main1(string[] args)
        {
            //FileStream 文件流
            //文件流的创建方式1 new   2 file类的封装的方法
            string path = @"E:\诛仙.txt";
            byte[] array = new byte[1024];//1kb的缓冲区
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                while (true)
                {
                    Console.ReadLine();
                    int length = fs.Read(array, 0, array.Length);//返回值是真实的读取长度

                    string str = Encoding.Default.GetString(array, 0, length);//读取多少就解码多少个
                    Console.WriteLine(str);

                }
            }   
        }
        //写入
        static void Main(string[] args)
        {
            //控制台读一行,文件流写一行
            using (FileStream fs = File.Create(@"D:\text.txt"))
            {
                while (true)
                {
                    string str = Console.ReadLine();
                    if (str == "exit")
                    {
                        break;
                    }
                    byte[] bytes = Encoding.UTF8.GetBytes(str+"\r\n");
                    fs.Write(bytes, 0, bytes.Length);
                }
                fs.Flush();//
            }        
            //fs.Dispose();//释放(立即销毁fs对象)//使用using
            //fs.Close();//关闭
        }



















        //        网络流
        //MemoryStream内存流
    }
    class MyClass
    {
        public MyClass()
        {

        }
        ~MyClass()//析构函数销毁时执行的代码
        {

        }
    }
}
