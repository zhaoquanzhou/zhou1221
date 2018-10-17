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
            Console.WriteLine("{0}攻击了玩家,攻击力为:{1}", nameManster, atckManster);
        }

        public void Attck(int atckManster)
        {
            Console.WriteLine("{0}攻击伤害为{1}", nameManster, atckManster);
        }
    }
}