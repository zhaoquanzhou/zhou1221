using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ini文件读取类
{
    class IniFile
    {
        //存储数据的容器:字典套字典
        Dictionary<string, Dictionary<string, string>> dic = new Dictionary<string, Dictionary<string, string>>();
        public string GetString (string mainKey,string subKey)
        {
            return dic[mainKey][subKey];
        }

        #region 静态方法
        //提供一个打开的静态方法返回一个Ini对象
        public static IniFile Open(string path)
        {
            //创建Ini对象
            IniFile ini = new IniFile();
            //拿到字典对象
            var dic = ini.dic;
            string[] arr = File.ReadAllLines(path);//ini文件中所有行的读取
            string mainKey="";
            foreach (var item in arr)
            {
                string line = item.Trim();
                if (string.IsNullOrWhiteSpace(line)) continue;//跳过空行
                //主键
                if (line.StartsWith("["))
                {
                    mainKey = line.Substring(1,line.Length-2);
                    dic.Add(mainKey,new Dictionary<string, string>());//外层添加元素:主键-添加字典
                }
                else
                {
                    string[] kv = line.Split('=');//用等号分成两段
                    dic[mainKey].Add(kv[0].Trim(),kv[1].Trim());
                }
               
            }
            return ini;
        }
        //提供一个保存Ini对象到文件的静态方法

        #endregion

    }
}
