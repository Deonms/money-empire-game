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
        private float _autoIncome = 0;
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        private Shopping _shop = new Shopping("", 0, "");
        private bool _shopLoaded = false;





        public void Earnmoney()
        {
            if (!_shopLoaded)
            {
                _shop.AllShopItems();
                _shopLoaded = true;
            }

            _working = Console.ReadLine();
            Console.Clear();

            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
            }
            else if (_working == "/shop help" || _working == "/shop Help")
            {
                foreach (OvereverenShop item in _shop.ShoppingList)
                {
                    item.ShowItem();
                }

                Console.WriteLine("use /shop buy (item)");
            }
            else if (_working == "/shop buy String")
            {
                if (_money >= 5)
                {
                    _money = _money - 5;
                    _autoIncome = _autoIncome + 1;
                    Console.WriteLine("String is gekocht en boost je cps en je multiplier");
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                }
            }
            else
            {
                Console.WriteLine("Niet goed getypt");
            }

            Console.WriteLine($"Money: {_money}");
            Console.WriteLine($"Mulitplier: {_multiplier}");
            Console.WriteLine($"Auto Income: {_autoIncome}");
        }
    }
}
