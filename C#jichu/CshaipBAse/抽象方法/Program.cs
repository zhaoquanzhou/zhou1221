using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用的时候和普通的父子类一样的规则
        }
    }
    abstract class Animal//抽象类可以包含普通类成员,特点:可以包含抽象方法
    {
        
        public abstract void Shout();//抽象方法,不能有方法体,必须写在抽象类中
    }
    class Dog : Animal
    {
        public override void Shout()
        {
            Console.WriteLine("汪汪");
        }
    }
    class Cat : Animal
    {
        public override void Shout()
        {
            Console.WriteLine("喵喵");
        }
    }
}
