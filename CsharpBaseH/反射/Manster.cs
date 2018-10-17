using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射
{
    internal class Manster
    {
        private string nameManster;
        private int atckManster;
        private int defManster;

        public Manster()
        {
        }

        public Manster(string nameManster, int atckManster, int defManster)
        {
            this.nameManster = nameManster;
            this.atckManster = atckManster;
            this.defManster = defManster;
        }

        public void Attck()
        {
            Console.WriteLine("你被攻击了");
        }
    }
}