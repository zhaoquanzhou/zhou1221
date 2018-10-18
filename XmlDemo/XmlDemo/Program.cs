using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo
{
    internal class Program
    {
        private static void Main1(string[] args)
        {
            #region 写xml

            //创建XmlDocument对象
            XmlDocument document = new XmlDocument();
            XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "utf-8", null);
            document.AppendChild(declaration);
            //主节点
            XmlElement mainElement = document.CreateElement("MyBook");
            document.AppendChild(mainElement);
            //子节点
            XmlElement book1 = document.CreateElement("Book");
            mainElement.AppendChild(book1);
            XmlElement name1 = document.CreateElement("Name");
            name1.InnerText = "高等数学";
            book1.AppendChild(name1);
            XmlElement price1 = document.CreateElement("Price");
            price1.InnerText = "35";
            book1.AppendChild(price1);
            XmlElement count1 = document.CreateElement("Count");
            count1.InnerText = "1";
            book1.AppendChild(count1);
            document.Save("MyBook.xml");
            Console.WriteLine("保存成功");

            #endregion 写xml
        }

        private static void Main2(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"E:\Order.xml");
            //版本和字体类型
            Console.WriteLine(xml.FirstChild.Value);
            //根节点
            float sumPrice = 0;
            XmlNode root = xml.LastChild;
            Console.WriteLine(root.Name);
            float price = 0;
            int count = 0;
            foreach (XmlNode node in root.ChildNodes)
            {
                foreach (XmlNode nodeChild in node.ChildNodes)
                {
                    Console.Write("{0}:{1}", nodeChild.Name, nodeChild.InnerText + "\n");
                    if (nodeChild.Name.Equals("Price"))
                    {
                        price = float.Parse(nodeChild.InnerText);
                    }
                    else if (nodeChild.Name.Equals("Count"))
                    {
                        count = int.Parse(nodeChild.InnerText);
                    }
                    sumPrice += price * count;
                }
                Console.WriteLine(sumPrice);
            }
        }

        private static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();
            //创建对象 XmlDocument
            XmlDocument plantxml = new XmlDocument();
            plantxml.Load(@"E:\XMLTest.xml");
            //版本和字体类型
            Console.WriteLine(plantxml.FirstChild.Value);
            //根节点
            XmlNode root = plantxml.LastChild;
            Console.WriteLine(root.Name);
            foreach (XmlNode node in root.ChildNodes)
            {
                Plant plant1 = new Plant();
                foreach (XmlNode chlidNode in node.ChildNodes)
                {
                    Console.Write("{0}:{1}", chlidNode.Name, chlidNode.InnerText + "\n");
                    if (chlidNode.Name.Equals("COMMON"))
                    {
                        plant1.Common = chlidNode.InnerText;
                    }
                    else if (chlidNode.Name.Equals("BOTANICAL"))
                    {
                        plant1.Botanical = chlidNode.InnerText;
                    }
                    else if (chlidNode.Name.Equals("ZONE"))
                    {
                        plant1.Zone = int.Parse(chlidNode.InnerText);
                    }
                    else if (chlidNode.Name.Equals("LIGHT"))
                    {
                        plant1.Light = chlidNode.InnerText;
                    }
                    else if (chlidNode.Name.Equals("PRICE"))
                    {
                        plant1.Price = float.Parse(chlidNode.InnerText.Remove(0, 1));
                    }
                    else if (chlidNode.Name.Equals("AVAILABILITY"))
                    {
                        plant1.Availability = long.Parse(chlidNode.InnerText);
                    }
                }
                plants.Add(plant1);
            }
        }
    }
}