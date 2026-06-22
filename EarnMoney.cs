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
        private float _goedDoelValue = 0;

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
            Console.WriteLine($"{_goedDoelValue}/100000 gedoneert");

            if (_working == "work" || _working == "Work")
            {
                _money = _money + (1 * _multiplier);
                _timer = _timer + 1;
            }
            else if (_working.StartsWith("/shop"))
            {
                _shopps.shops(_working, ref _money, ref _multiplier, ref _autoIncome, ref _timer, _shop.ShoppingList);
            }
            else if (_working.StartsWith("/doneer"))
            {
                string[] doneerText = _working.Split();

                if (doneerText.Length > 1 && float.TryParse(doneerText[1], out float doneerMoney))
                {
                    if (_money >= doneerMoney)
                    {
                        _money = _money - doneerMoney;
                        _goedDoelValue = _goedDoelValue + doneerMoney;
                        _timer = _timer + 1;
                        Console.WriteLine("je hebt geld gedoneert");
                    }
                    else
                    {
                        Console.WriteLine("je hebt niet genoeg geld");
                        _timer = _timer + 1;
                    }
                }
                else
                {
                    Console.WriteLine("gebruik /doneer (bedrag)");
                    _timer = _timer + 1;
                }
            }
            else
            {
                Console.WriteLine("Niet goed getypt");
                _timer = _timer + 1;
            }
            if (_goedDoelValue == 100000)
            {
                Console.WriteLine("je bent een goed mens \nje hebt de 2de einde gevonden");
            }
        }
    }
}
