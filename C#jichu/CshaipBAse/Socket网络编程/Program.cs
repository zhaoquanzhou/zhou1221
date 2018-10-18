using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Socket网络编程
{
    class Program
    { 
        //服务端
        static void Main(string[] args)
        {
            //TCP可靠性高,效率高
            //UDP 可靠性低,只管发送不管接收
            //创建服务端socket
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            //绑定终结点  ip (网卡) 和端口 (应用程序编号)
            socket.Bind(new IPEndPoint(IPAddress.Any,5566));
            //socket设置监听状态
            socket.Listen(100);
            Console.WriteLine("开始监听");
            while (true)
            {
                try
                {
                    Socket clientSocket = socket.Accept();//接待客服端连接 一般是重复接待Accept方法会阻塞线程
                    Thread thread = new Thread(Receive);//创建一个线程对象
                    thread.Start(clientSocket);//开启线程,用于接收消息
                    Console.WriteLine("有新的连接:" + clientSocket.RemoteEndPoint);
                }
                catch 
                {

                    Console.WriteLine("有异常情况"); ;
                }
               
            }
        }
        //接收消息的方法
        static void Receive(Object arg)//开线程 线程间传参只能传Object
        {
            Socket clientSocket = arg as Socket;
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    //接收
                    int length = clientSocket.Receive(buffer);//返回值表示实践收到的字节数  Receive方法会阻碍线程
                                                              //解码
                    string msg = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.WriteLine(msg);
                }
                catch
                {

                    Console.WriteLine("有异常情况"); ;
                }
                
            }
        }
    }
}
