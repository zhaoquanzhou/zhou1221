using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重写
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Enemy();//父类引用指向子类对象(子到父的隐式转换)
           // Player p=(Player)character;//强制转换 如果转换失败,会报错
            Player p = character as Player;//as转换 如果转换失败,会返回null
            //Enemy enemy = (Enemy)character;//转换失败,会报错
            Enemy enemy = character as Enemy; //转换失败,会返回null

        }
    }

    //飞机大战

    /*死亡:
     * 角色(父类):播放爆炸特效
     * 玩家(子类) Game over
     * 敌人(子类) 加分
     */

    class Character
    {
        public virtual void Die()
        {
            Console.WriteLine( "播放爆炸特效");
        }
    }
    class Player:Character//角色父类
    {
        public override void Die()//父类中被virtual修饰的方法可以在子类中重写
        {
            base.Die();
            Console.WriteLine("Game over");
        }
        public void Fun()
        {
        }
    }
    class Enemy:Character
    {
        public override void Die()
        {
            base.Die();           
            int score = 0;
            while (true) 
            {
                Console.WriteLine("加分");
                score++;
                Console.WriteLine("分数为:{0}",score);
                break;
            } 
        }
    }

}
