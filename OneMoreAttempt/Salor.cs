using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreAttempt
{
    class Salor
    {
        private List<Good> goods = new List<Good>();
        private float money = 0;


        public Good CheckForGood(string itemName)
        {
            Good wontedGood = null;
            foreach (Good item in goods)
            {
                if (item.Name == itemName)
                {
                    wontedGood = new Good(item.Name, item.Price);
                    break;
                }
            }
            return wontedGood;
        }


        public void SellGood(string itemName, Player player)
        {
            Good goodForSale = CheckForGood(itemName);

            if (goodForSale != null)
            {
                if (player.Money >= goodForSale.Price)
                {
                    money += player.GetItem(goodForSale);
                    Console.WriteLine("Спасибо вот ваш товар" + goodForSale.Name +
                                      "C вас  " + goodForSale.Price);
                }
                else
                {
                    Console.WriteLine("Простите но вы не доплатили");
                }
            }
            else
            {
                Console.WriteLine("Простите но у нас нет такого товара");
            }

        }


        public void showGoods()
        {
            foreach (Good good in goods)
            {
                Console.WriteLine(good);
            }
        }


        public void addGood(Good good)
        {
            goods.Add(good);
        }
    }
}
