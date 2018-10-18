using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类图的使用
{
    class Book
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name;//书名
                           /// <summary>
                           /// 价格
                           /// </summary>
        public int price;//价格
                         /// <summary>
                         /// 作者
                         /// </summary>
        public string author;//作者
                             /// <summary>
                             /// 页数
                             /// </summary>
        public int page;
        /// <summary>
        /// 描述
        /// </summary>
        public string desc;

        public Book(string name, int price, string author)
        {
            this.name = name;
            this.price = price;
            this.author = author;
        }
        public Book()
        {

        }
    }
}
