using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Socke网络编程1
{
    class Program
    {
       //客户端
        static void Main(string[] args)
        {
            //创建socket对象
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //连接服务端
            socket.Connect(IPAddress.Parse("192.168.2.254"),5566);
            Console.WriteLine("连接成功");
            while (true)
            {
                Console.WriteLine("请输入要发给服务的消息:");
                string msg = Console.ReadLine();
                byte[] butter = Encoding.UTF8.GetBytes(msg);
                socket.Send(butter);
            }
            
        }
    }
}
