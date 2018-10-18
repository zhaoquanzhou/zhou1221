using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.age = 8;//从父类中继承过来的成员
            cat.sex = "公";//从父类中继承过来的成员
            cat.sleep();//从父类中继承过来的成员
            cat.CatchMouse();//子类自己定义的成员
        }
    }
    class Animal//动物类:我们把子类共有成员放到父类达到代码复用的目的
    {
        public string sex;
        public int age;
        public void sleep()
        {
        }
    }
    class Cat:Animal
    {
        public void CatchMouse()
        {
        }
    }
    class Dog :Animal
    {
        public void WatchDoor()
        {
        }
    }
}
