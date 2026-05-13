using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Shop
    {
        private Shop _shop = new Shop("hi", 10, "info");
        private string _working;
        private float _money;
        private float _multiplier = 1;

        public void Earnmoney()
        {
            _working = Console.ReadLine();
            Console.Clear();
            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}");
            }
            else if (_working == "/shop help" || _working == "/shop Help")
            {
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}")
                Console.WriteLine("shopping");
            }
            else
            {
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}");
                Console.WriteLine("Niet goed getypt");
            }
        }
    }
}
