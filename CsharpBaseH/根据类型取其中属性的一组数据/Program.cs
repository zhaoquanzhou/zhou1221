using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 根据类型取其中属性的一组数据
{
    internal class Program
    {
        public delegate Tkey SelectHanler<T, Tkey>(T t);

        public delegate bool FindAllHanler<T>(T t);

        private static void Main(string[] args)
        {
            Player[] player =
            {
             new Player(10,20,14),
             new Player(12,28,17),
             new Player(8,13,23)
            };
            int[] hp = SelectHp(player, p => p.hp);
            foreach (var item in hp)
            {
                Console.WriteLine(item);
            }
            Player[] arr = FindAll(player, p => p.hp > 10);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static Tkey[] SelectHp<T, Tkey>(T[] arr, SelectHanler<T, Tkey> hanler)
        {
            Tkey[] tkeys = new Tkey[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                tkeys[i] = hanler(arr[i]);
            }
            return tkeys;
        }

        public static T[] FindAll<T>(T[] arr, FindAllHanler<T> hanler)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hanler(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }
    }

    internal class Player
    {
        public int hp;
        public int mp;
        public int atck;

        public Player(int hp, int mp, int atck)
        {
            this.hp = hp;
            this.mp = mp;
            this.atck = atck;
        }
    }

    internal class Emeny
    {
        public int hp;
        public int def;
        public int atck;

        public Emeny(int hp, int def, int atck)
        {
            this.hp = hp;
            this.def = def;
            this.atck = atck;
        }
    }
}