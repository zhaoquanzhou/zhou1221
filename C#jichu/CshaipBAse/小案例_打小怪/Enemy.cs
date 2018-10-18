using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 小案例_打小怪
{
    class Enemy
    {
        //名字
        public string name;
        //最大血量
        public int maxHp;
        //当前血量
        public int hp;
        //防御力
        public int def;
        //可掉落物品[]
        public string[] items;
        public Enemy(string name, int maxHp, int hp, int def, string[] items)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = hp;
            this.def = def;
            this.items = items;
        }

        //受伤
        public bool Damage(int vaiue)
        {
            hp -= (vaiue - def);//当前血量减去伤害
            if (hp<=0)
            {
                hp = 0;
                Die();
                return true;
            }
            Console.WriteLine("受伤了,当前血量;{0}",((float)hp/maxHp).ToString("p"));
            return false;//没死
        }
        //死亡
        private void Die()
        {
            Console.WriteLine("你已经死了");
            Drop();//掉落
        }

        //掉落物品
        private void Drop()
        {
            Random ran = new Random();
            int index = ran.Next(0,items.Length);
            string item = items[index] ;
            Console.WriteLine("掉落了:[{0}]",items);
        }
    }
}
