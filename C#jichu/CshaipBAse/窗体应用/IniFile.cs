using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IniFile
{
    //存储数据的容器:字典套字典
    Dictionary<string, Dictionary<string, string>> dic = new Dictionary<string, Dictionary<string, string>>();
    private string path;
    public void Save(string path = "")
    {
        Save(this, path);
    }
    #region 获取和设置数据
    public string GetString(string mainKey, string subKey)
    {
        return dic[mainKey][subKey];
    }
    public void SetString(string mainKey, string subKey, string value)
    {
        if (!dic.ContainsKey(mainKey))//确保有MainKey
        {
            dic.Add(mainKey, new Dictionary<string, string>());
        }
        if (!dic[mainKey].ContainsKey(subKey))//确保有SubKey
        {
            dic[mainKey].Add(subKey, null);
        }
        dic[mainKey][subKey] = value;
    }
    //索引器
    public string this[string mainKey, string subKey]
    {
        get { return dic[mainKey][subKey]; }
        set//有就改,没有就添加
        {
            SetString(mainKey, subKey, value);
        }
    }
    #endregion

    #region 静态方法
    //提供一个打开文件的静态方法返回一个ini对象
    public static IniFile Open(string path)
    {
        //创建Ini对象
        IniFile ini = new IniFile();
        ini.path = path;
        //拿到ini对象的字典
        var dic = ini.dic;

        string[] arr = File.ReadAllLines(path);//ini文件中所有行
        string mainKey = "";//当前主键

        foreach (var item in arr)
        {
            string line = item.Trim();

            if (string.IsNullOrWhiteSpace(item)) continue;//跳过空行
                                                          //主键
            if (line.StartsWith("["))
            {
                mainKey = line.Substring(1, line.Length - 2);
                dic.Add(mainKey, new Dictionary<string, string>());//外层字典添加元素  :   主键-内层字典
            }
            else   //子键
            {
                string[] kv = line.Split('=');//等号分割成两段
                dic[mainKey].Add(kv[0].Trim(), kv[1].Trim());
            }
        }
        return ini;
    }

    //提供一个保存ini对象到文件的静态方法
    public static void Save(IniFile ini, string path = "")
    {
        if (path == "")
        {
            path = ini.path;
        }
        //ini 的字典  转成一个大字符串
        StringBuilder sb = new StringBuilder();
        foreach (var mainKey in ini.dic.Keys)//item外层字典的主键
        {
            sb.AppendLine(string.Format("[{0}]", mainKey));
            foreach (var kv in ini.dic[mainKey])
            {
                sb.AppendLine(string.Format("{0}={1}", kv.Key, kv.Value));
            }
        }
        //把字符串写入文件
        File.WriteAllText(path, sb.ToString());
    }
    #endregion

}
