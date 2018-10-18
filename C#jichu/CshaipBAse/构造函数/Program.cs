using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Student xiaoming = new Student("小铭",15,1.75f);
            Circle cir = new Circle(3.2f);
            Rectangle rect = new Rectangle(1.6f,2.4f);
        }
    }
    class Student
    {
        //成员变量(字段)
        public string name;//姓名
        public int age;//年龄
        public float height;//身高
        //构造函数不需要写返回值
        //系统默认赠送公共无参构造函数
        public Student(string name)
        {
            this.name = name;
            
        }
        public Student(string name, int age):this(name)
        {
            this.age = age;
           
        }
        public Student(string name, int age, float height):this(name,age)
        {
            this.height = height;
        }
    }
    class Rectangle
    {
        public float length;
        public float width;
        public Rectangle(float length,float width)
        {
            this.length = length;
            this.width = width;
        }
        public float Area()
        {
            return length * width;          
        }
        public float Perimete()
        {
            return 2f * (length + width);          
        }
    }
    class Circle
    {
        public float radius;
        
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float Perimete()
        {
            return 2f * (float)Math.PI * radius;
        }
        public float Area()
        {
            return (float)Math.PI * radius * radius;
        }
    }
   
}
