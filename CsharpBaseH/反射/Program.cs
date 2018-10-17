using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //创建目标对象
            Type type1 = typeof(Manster);
            //根据对象
            Manster manster = new Manster();
            Type type2 = manster.GetType();
            //需要命名空间和对象名称
            Type type3 = Type.GetType("反射.Manster");
            //获取构造函数
            ConstructorInfo[] infos = type1.GetConstructors();
            foreach (var item in infos)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in infos)
            {
                ParameterInfo[] parameters = item.GetParameters();
                foreach (var pare in parameters)
                {
                    Console.WriteLine(pare.Name);
                }
            }
            //
            Type[] types = new Type[3];
            types[0] = typeof(string);
            types[1] = typeof(int);
            types[2] = typeof(int);
            ConstructorInfo con = type1.GetConstructor(types);
            //创建对象
            // invoke
            object[] obj = new object[3] { "牛头怪", 12, 10 };
            object oo = con.Invoke(obj);
            Manster manster1 = oo as Manster;
            manster1.Attck();
            //Activator
            Manster manster2 = Activator.CreateInstance(type1, obj) as Manster;
            manster2.Attck();
        }
    }
}