using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "张三";
            string a = "李四";
           
            
            //string.Format(); //格式化
            string b = string.Format("已杀敌{0:000}人", 10);
            string bb = string.Format("当前进度{0:p}", 0.51);
            string cc = "你好中国";

            //string.IsNullOrWhiteSpace();//是null,或空字符串 或者只有空格
            bool relut = string.IsNullOrWhiteSpace(str);
            //string.Concat(); //合并多个字符串
            string str2 = string.Concat(str, a);
            Console.WriteLine(str2);
            //string.Join(); //用指定符号连接多个字符串

            //Insert();//插入
 
            //StartsWith();//是否以...开始
           
     
            //EndsWith(); //是否以...结尾
           
       
            //Remove(); //移除      
            //Substring();//截取          
            //Replace(); //替换
            //Split();//分割
            //ToLower(); //转小写
            //ToUpper();//转大写
            //Trim();//默认删除首尾空格 可以用参数指定要删除的首尾字符
            string arr4 = " A***";
            string arr3 = arr4.Trim(' ','*');
            //TrimEnd();//删除首尾空格
            //ToCharArray();//转字符数组
            char[] arr5 = cc.ToCharArray();
        }
    }
}
