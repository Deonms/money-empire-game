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
        private float _boughtMultiplier = 1;
        private int _timer;
        private bool _gameRunning = false;

        public float BoughtMultiplier
        {
            get { return _boughtMultiplier; }
            set { _boughtMultiplier = value; }
        }

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

            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
                _timer = _timer + 1;
            }
            else if (_working == "/shop help" || _working == "/shop Help")
            {
                foreach (OvereverenShop item in _shop.ShoppingList)
                {
                    item.ShowItem();
                }
                _timer = _timer + 1;
                Console.WriteLine("use /shop buy (item)");
            }
            else if (_working == "/shop buy String" || _working == "/shop buy string")
            {
                if (_money >= 5*_boughtMultiplier)
                {
                    _money = _money - 5* _boughtMultiplier;
                    _autoIncome = _autoIncome + 1;
                    _multiplier = _multiplier + 0.5f;
                    _timer = _timer + 1;
                    Console.WriteLine("String is gekocht en boost je cps en je multiplier");
                    _boughtMultiplier = _boughtMultiplier + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else
            {
                Console.WriteLine("Niet goed getypt");
                _timer = _timer + 1;
            }

            Console.WriteLine($"Money: {_money}");
            Console.WriteLine($"Mulitplier: {_multiplier}");
            Console.WriteLine($"Auto Income: {_autoIncome}");
            Console.WriteLine($"Timer {_timer}");
        }
    }
}
