using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreAttempt
{
    class Good
    {
        private string name;
        private float price;


        public string Name
        {
            get { return name; }
        }
        public float Price
        {
            get { return price; }
        }


        public Good(string name, float price)
        {
            this.name = name;
            this.price = price;
        }


        public override string ToString()
        {
            return "\n Имя товара : " + name + '\n' +
            "Цена товара : " + price.ToString();
        }
    }
}
