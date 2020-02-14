using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreAttempt
{
    class ShotTest
    {
        static public void Main(String[] args)
        {
            Salor Ahmad = new Salor();
            Player Usuf = new Player("Usuf", 500);

            Good sword = new Good("sword", 50);
            Good shild = new Good("shild", 150);
            Good armor = new Good("armor", 200);

            Ahmad.addGood(sword);
            Ahmad.addGood(shild);
            Ahmad.addGood(armor);

            Console.WriteLine("Привет покупатель хочеш посмотреть мои товары");
            Console.WriteLine("да нажмите : y ");
            Console.WriteLine("нет нажмите : n");

            char wish = Console.ReadKey().KeyChar;
            while (wish != 'y' && wish != 'n')
            {
                Console.WriteLine(" \nНеверная кнопка напишите верную");
                wish = Console.ReadKey().KeyChar;
            }


            if (wish == 'n')
            {
                Console.WriteLine("\n Спасибо будьте добры заходите еще");
            }

            else if (wish == 'y')
            {
                Console.WriteLine("\nВот все мои товары");
                Ahmad.showGoods();

                Console.WriteLine("Что хочеш купить ");

                char wishItem = Console.ReadKey().KeyChar;
                while (wishItem != '1' && wishItem != '2' && wishItem != '3')
                {
                    Console.WriteLine(" \nНеверная кнопка напишите верную");
                    wishItem = Console.ReadKey().KeyChar;
                }

                switch (wishItem)
                {
                    case '1':
                        Console.WriteLine("Прекрасный меч очень советую");
                        Usuf.BuyItem("sword", Ahmad);
                        break;
                    case '2':
                        Console.WriteLine("Прекрасный щит сам им пользуюсь");
                        Usuf.BuyItem("shild", Ahmad);
                        break;
                    case '3':
                        Console.WriteLine("Прекрасный броня таких вы еще не видели");
                        Usuf.BuyItem("armor", Ahmad);
                        break;
                }
            }

            Console.Read();
        }
    }
}
