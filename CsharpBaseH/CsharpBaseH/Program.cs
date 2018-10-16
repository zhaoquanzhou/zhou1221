using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBaseH
{
    #region 接口
    interface IMyInterface
    {
        void Hp();
        void Creat();
        object this[int index]
        {
            get;
            set;
        }
        int Harm { get; set; }
    }
    interface IMyOnattack
    {
        void OnAttack();
    }
    class Program
    {
        static void Main1(string[] args)
        {
            IMyInterface myInterface = new Players();
            myInterface.Creat();
            myInterface.Hp();
            Players players = new Players();
            players.Creat();
        }
    }
    class Players : IMyInterface, IMyOnattack
    {
        public object this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        int IMyInterface.Harm
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Creat()
        {
            Console.WriteLine("生成一个玩家"); ;
        }

        //public void Hp()
        //{
        //    int hp = 100;
        //    Console.WriteLine(hp);
        //}

        public void OnAttack()
        {
            Console.WriteLine("攻击"); ;
        }

        void IMyInterface.Creat()
        {
            throw new NotImplementedException();
        }

        void IMyInterface.Hp()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class MyClassabstract
    {
        public abstract void OnCreat();
    }
    class A
    {
        private int hp;

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }
    }
    class B
    {
    }

    class CompareDemo
    {
        static void Main2(string[] args)
        {
            //ICompareble //比较功能
            Npc npc1 = new Npc(15);
            Npc npc2 = new Npc(50);
            Npc npc3 = new Npc(15);
            //
            int a = npc1.CompareTo(npc2);
            Console.WriteLine(a);
        }
    }
    class Npc : IComparable
    {
        public int hp;
        public Npc(int _hp)
        {
            hp = _hp;
        }
        public int CompareTo(object obj)
        {
            Npc n = obj as Npc;
            if (n == null)
            {
                throw new Exception("传入参数错误");
            }
            return hp.CompareTo(n.hp);
        }
    }
    #endregion


}
