using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        static void Main(string[] args)
        {
            //A cnum = new A();//类是引用类型
            //B bnum = new B();//结构体是值类型
            //int i = 6;
            //ITestAble[] p = { cnum,bnum };
            //结构体自动分配内存空间,类要new后分配内存空间
          
        }
      
    }
    class A:ITestAble
    {
        public int cnum;
        public int x;

        public A()
        {
        }

        public void Test()
        {
            throw new NotImplementedException();
        }

       
    }
    struct B:ITestAble//结构体不可以继承,但可以实现接口
    {
        public int bnum;
        int x;
        public B(int bnum)
        {
            this.bnum = bnum;
            x = 6;
        }   
        //结构体无法申明默认构造函数
        public void Test()
        {
            throw new NotImplementedException();
        }        
    }
    interface ITestAble//接口只能包含方法头,或属性或事件.使用方式与抽象类相似,接口强调能做什么,抽象类强调是什么
    {
        void Test();//不能写访问修饰符
    }
   
}
