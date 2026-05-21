using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class EaningMoney
    {
        
        private string _working;
        private float _money;
        private float _multiplier = 1;
        private float _cps = 0;
        public List<Shopping> ShoppingList = new List<Shopping>();
        private Shopping _shop = new Shopping("", 0, "", 0, 0);




        public void Earnmoney()
        {
            _shop.AllShopItems();
            _working = Console.ReadLine();
            Console.Clear();
            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}");
                Console.WriteLine($"cps: {_cps}");
            }
            else if (_working == "/shop help" || _working == "/shop Help")
            {
                Console.Clear();
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}");
                Console.WriteLine($"cps: {_cps}");
                foreach (Shopping item in _shop.ShoppingList)
                {
                    item.SeeShop();
                }

                Console.WriteLine("use /shop buy (item)");

            }
            else
            {
                Console.WriteLine($"Money: {_money}");
                Console.WriteLine($"Mulitplier: {_multiplier}");
                Console.WriteLine($"cps: {_cps}");
                Console.WriteLine("Niet goed getypt");
            }
        }
    }
}
