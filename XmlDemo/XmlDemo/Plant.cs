using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo
{
    internal class Plant
    {
        private string common;
        private string botanical;
        private int zone;
        private string light;
        private float price;
        private long availability;

        public string Common { get => common; set => common = value; }
        public string Botanical { get => botanical; set => botanical = value; }
        public int Zone { get => zone; set => zone = value; }
        public string Light { get => light; set => light = value; }
        public float Price { get => price; set => price = value; }
        public long Availability { get => availability; set => availability = value; }
    }
}