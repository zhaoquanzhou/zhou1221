using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(Sex.boy);
            //拿到枚举项的名称
            string s = person.sex.ToString();
            Console.WriteLine(s);
            Console.WriteLine((int)person.sex);
            //整数转枚举
            //int x = 1;
            //Sex sex = (Sex)x;
            //Console.WriteLine(sex.ToString());
            //字符串转枚举
            string str = "boy";
            Sex sex = (Sex)Enum.Parse(typeof(Sex), str);
            Console.WriteLine(str);
            File file = new File(FileProperty.readable | FileProperty.writeable);
            Console.WriteLine(file.property);
        }
    }
    class Person
    {
        public Sex sex;
        public Person(Sex sex)
        {
            this.sex = sex;
        }
    }
    enum Sex
    {
        boy = 1,
        girl = 2
    }

    //标志枚举
    class File
    {
        public FileProperty property;
        public File(FileProperty property)
        {
            this.property = property;
        }
    }
    [Flags]
    enum FileProperty
    {          
        readable = 1,
        writeable = 2,
        hide = 4

    }

}
