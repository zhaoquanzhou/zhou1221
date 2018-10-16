using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
    //写一个接口,让CardManager继承并实现此接口,可以实现打印任意卡片的折扣值的功能
    interface ICardManager
    {
        void CardPercnet<T>(T card) where T : CardBase;
    }
    class CardManager: ICardManager
    {
     
        public void CardPercnet<T>(T card) where T : CardBase
        {
            Console.WriteLine(card.ReturnPercent());
            
        }
    }
    //卡片基类
    abstract class CardBase
    {
        public abstract float ReturnPercent();
    }
    //金卡
    class GoldCard : CardBase
    {
        public override float ReturnPercent()
        {
            return 0.7f;
        }
    }
}
