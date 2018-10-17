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
        private static void Main1(string[] args)
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
                    Console.WriteLine(pare.ParameterType + "......");
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
            Console.WriteLine("__________________________________________");
            MethodInfo[] methods = type1.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("{0}返回值:{1}", item.Name, item.ReturnType);
                ParameterInfo[] parameters = item.GetParameters();
                foreach (var pare in parameters)
                {
                    Console.WriteLine(pare.ParameterType + ".......");
                }
            }
            MethodInfo method = type1.GetMethod("Attck", new Type[] { });
            method.Invoke(oo, null);
            //方法重置
            MethodInfo method1 = type1.GetMethod("Attck", new Type[1] { typeof(int) });
            method1.Invoke(oo, new object[] { 12 });
            //获取字段
            Console.WriteLine("___________________________________________");
            FieldInfo[] field = type1.GetFields();
            foreach (var item in field)
            {
                Console.WriteLine("{0}....{1}....{2}", item.Name, item.FieldType, item.IsStatic);
            }
            //FieldInfo infofielf = type1.GetField("nameManster");
            //infofielf.SetValue(oo, 17);
            //type1.GetMethod("Attck", new Type[] { }).Invoke(oo, null);
        }

        private static void Main(string[] args)
        {
            //反射程序集

            //1加载程序集信息
            Assembly assembly = Assembly.LoadFrom("HomeWork.dll");
            //2获取类型信息(Type对象)
            Type[] types = assembly.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine(item.FullName);
            }
            Type type = assembly.GetType("HomeWork.Enemy");
            Console.WriteLine(type);
            //获取构造函数 创建对象 调用方法 修改字段;
            //获取构造函数
            Console.WriteLine("___________________________");
            ConstructorInfo[] constructorInfo = type.GetConstructors();
            foreach (var item in constructorInfo)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            foreach (var item in constructorInfo)
            {
                ParameterInfo[] parameterInfo = item.GetParameters();
                foreach (var para in parameterInfo)
                {
                    Console.Write(para.Name + ":" + para.ParameterType + ".......");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________________");
            //创建对象
            // 1 invoke

            ConstructorInfo con = type.GetConstructor(new Type[] { typeof(string) });

            object obj = con.Invoke(new object[] { "这是一个类库" });
            Console.WriteLine("___________________");
            //调用方法
            foreach (var item in type.GetMethods())
            {
                foreach (var para in item.GetParameters())
                {
                    Console.Write(item.Name + ":" + para + "...");
                }
                Console.WriteLine();
            }
            MethodInfo method = type.GetMethod("SetName");
            method.Invoke(obj, new object[] { "这是一个方法" });
            foreach (var item in type.GetFields())
            {
                Console.WriteLine(item.Name + "...." + item.FieldType);
            }
            Console.WriteLine("_____________________________________");
            FieldInfo fieldInfo = type.GetField("name");
            Console.WriteLine(fieldInfo.GetValue(obj));
        }
    }
}