using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO操作
{
    class Program
    {
        //File 类
        static void Main1(string[] args)
        {
            string path = @"E:\a.txt";
            //File.Exists(); //判断文件是否存在
            Console.WriteLine(File.Exists(path));
            //File.ReadAllText(); //读取所有文本
            Console.WriteLine(File.ReadAllText(path)); //改成Utf8编码
                                                       //File.WriteAllText(); //写入所有文本
                                                       //string input = Console.ReadLine();
                                                       //File.WriteAllText(path,input);
                                                       //Console.WriteLine("写入成功");
                                                       //File.AppendAllText(); //追加所有文本

            //while (true)
            //{

            //    //string input1 = Console.ReadLine();
            //    //File.AppendAllText(path, input1+ "\r\n");
            //}
            //File.ReadAllLines(); //读取所有行返回字符串数组
            //string[] arr = File.ReadAllLines(path);

            //File.WriteAllLines() //写入所有行
            //File.WriteAllLines(path,new string[] { "明月天涯","如寄","眉间雪","风花雪月"});
            //File.ReadAllBytes(); //读取所有字节
            byte[] arr = File.ReadAllBytes(path);
            Console.WriteLine(arr);
            string str = Encoding.UTF8.GetString(arr);
            Console.WriteLine(str);
            //File.WriteAllBytes(); //写入所有字节

            //File.Delete(); //删除

            CopyFile(path, @"E:\b.txt");


        }

        //Directory 目录
        static void Main2(string[] args)
        {
            string path = @"E:\文献";
            //Directory.CreateDirectory(); //创建目录
            //Directory.CreateDirectory(path);
            //Directory.Delete(); //删除
            //Directory.Delete(path);
            //Directory.Exists(); //目录是否存在
            //Console.WriteLine(Directory.Exists(path));
            //Directory.GetFiles(); //获取所有文件
            //string[] str= Directory.GetFiles(@"D:\");
            // foreach (var item in str)
            // {
            //     Console.WriteLine(item);
            // }
            //Directory.GetDirectories(); //获取所有目录

            //string[] str = Directory.GetDirectories(@"D:\");
            // foreach (var item in str)
            // {
            //     Console.WriteLine(item);
            // }
            //Directory.GetCurrentDirectory(); //获取当前程序的工作目录
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Directory.Move(); //移动目录和目录中的内容,必须在同一分区

            //Directory.GetLogicalDrives(); //获取电脑上的盘符信息
            string[] str=Directory.GetLogicalDrives();
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            //也可以使用DirectoryInfo对象操作目录
            DirectoryInfo info = new DirectoryInfo(@"D:\aa");
        }
        // Path类 路径
        static void Main()
        {
            //Path.Combine(); //连接
            string str = Path.Combine(@"E:\11\", "aa.txt");
            Console.WriteLine(str);
            //Path.GetExtension(); //获取扩展名
            Console.WriteLine(Path.GetExtension(str));
            //Path.GetFileName(); //获取文件名
            Console.WriteLine(Path.GetFileName(str));
            //Path.GetFileNameWithoutExtension(); //获取没有扩展名的文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension("aa.txt"));
            //Path.GetFullPath(); //获取完整路径
            Console.WriteLine(Path.GetFullPath("aa.txt"));

        }
        public static void CopyFile(string oldpath, string newpath)
        {
            string[] arr = File.ReadAllLines(oldpath);
            File.WriteAllLines(newpath, arr);
        }
    }
}
