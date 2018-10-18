using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象_定义类和创建对象的基本语法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student
            Student xiaoming = new Student(); //创建对象
            Student xiaohong = new Student();
            Random ran = new Random();
            xiaoming.age = 15;//给小名对象的age变量赋值
            xiaoming.name = "小名";
            xiaoming.height = 1.7f;
            xiaoming.SayHello();//我是小名,今年15岁,身高有1.7米.
            #endregion


            Rectangle juxing = new Rectangle();
            juxing.length = 13.7f;
            juxing.width = 3.4f;
            Console.WriteLine("周长:{0},面积:{1}", juxing.Perimete(), juxing.Area());

            Circle cir = new Circle();
            cir.radius = 6.3f;
            Console.WriteLine("圆的周长是{0},面积是{1}", cir.Perimete(), cir.Area());


        }
    }
    class Student
    {
        //成员变量(字段)
        public string name;
        public int age;
        public float height;
        //方法
        public void SayHello()
        {
            Console.WriteLine("我是{0},今年{1}岁,身高有{2}米", name, age, height);
        }
    }
    class Rectangle
    {
        public float length;
        public float width;
        public float Area()
        {
            float area = length * width;
            return area;
        }
        public float Perimete()
        {
            float perimete = 2f * (length + width);
            return perimete;
        }
    }
    class Circle
    {
        public float radius;
        public float Perimete()
        {
            return 2f *(float)Math.PI * radius;
        }
        public float Area()
        {
            return (float)Math.PI * radius * radius;
        }
    }
}
