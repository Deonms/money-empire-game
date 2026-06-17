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
        
        //other
        private int _timer;
        private bool _gameRunning = false;
        private Shopps _shopps = new Shopps();

        public void Update()
        {
            while (_gameRunning)
            {
                Earnmoney();
            }
        }

        public void Earnmoney()
        {
            if (!_shopLoaded)
            {
                _shop.AllShopItems();
                _shopLoaded = true;
            }
            if (_timer == 30)
            {
                _timer = 0;
                _money = _money + _autoIncome;
            }
            _working = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Money: {_money}");
            Console.WriteLine($"Mulitplier: {_multiplier}");
            Console.WriteLine($"Auto Income: {_autoIncome}");
            Console.WriteLine($"Timer {_timer}");

            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
                _timer = _timer + 1;
            }
            else if (_working.StartsWith("/shop"))
            {
                _shopps.shops(_working, ref _money, ref _multiplier, ref _autoIncome, ref _timer, _shop.ShoppingList);
            }
            else
            {
                Console.WriteLine("Niet goed getypt");
                _timer = _timer + 1;
            }
        }
    }
}
