using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托与事件作业
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunPlayer player = new RunPlayer();
            Judge judge = new Judge();
            //订阅事件
            judge.RunEvent += player.Run;
            judge.ShootStart();
        }
    }

    //被观察的对象 事件发布者
    internal class Judge
    {
        public delegate void RunHandler();

        public event RunHandler RunEvent;//事件对象

        public void ShootStart()
        {
            RunEvent();
        }
    }

    //观察的对象 事件订阅者
    internal class RunPlayer
    {
        public void Run()
        {
            Console.WriteLine("开始奔跑了");
        }
    }
}