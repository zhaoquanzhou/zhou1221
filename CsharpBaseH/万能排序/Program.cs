using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 万能排序
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player[] player =
            {
             new Player(10,20,14),
             new Player(12,28,17),
             new Player(8,13,23)
            };

            RankObjcet(player, Obj => Obj.hp);
            foreach (var item in player)
            {
                Console.WriteLine(item.hp);
            }
        }

        //升序排序
        /// <summary>
        /// 选择委托
        /// </summary>
        /// <typeparam name="T">数据的类型</typeparam>
        /// <typeparam name="Tkey">属性的类型</typeparam>
        public delegate Tkey RankObjcetHandler<T, Tkey>(T Obj);

        public static T[] RankObjcet<T, Tkey>(T[] arr, RankObjcetHandler<T, Tkey> handler) where Tkey : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (handler(arr[i]).CompareTo(handler(arr[j])) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
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