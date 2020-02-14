using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreAttempt
{
    class Player
    {
        string name;
        private float money = 0;
        private List<Good> items = new List<Good>();

        public float payAmount;


        public Player(string name, float money)
        {
            this.name = name;
            this.money = money;
        }

        public float Money { get { return money; } }

        public string Name { get { return name; } }

        public float GetItem(Good item)
        {
            money -= item.Price;
            return item.Price;
        }

        public void BuyItem(string itemName, Salor salor)
        {
            salor.SellGood(itemName, this);
        }
    }
}
