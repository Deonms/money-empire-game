using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Shopps
    {
        //multiple buying
        private float _boughtMultiplierFriend = 1;
        private float _boughtMultiplierRestaurant = 1;
        private float _boughtMultiplierFabriek = 1;
        private float _boughtMultiplierBank = 1;
        private float _boughtMultiplierSpaceStation = 1;

        //one time buy
        private float _maximumBoughtHouse = 0;
        private float _maximumBoughtStreet = 0;
        private float _maximumBoughtVillage = 0;
        private float _maximumBoughtCity = 0;
        private float _maximumBoughtProvince = 0;
        private float _maximumBoughtCountry = 0;
        private float _maximumBoughtContinent = 0;
        private float _maximumBoughtWorld = 0;

        public void shops(string _working, ref float _money, ref float _multiplier, ref float _autoIncome, ref int _timer, List<OvereverenShop> ShoppingList)
        {
            if (_working == "/shop help" || _working == "/shop Help")
            {
                foreach (OvereverenShop item in ShoppingList)
                {
                    item.ShowItem();
                }

                _timer = _timer + 1;
                Console.WriteLine("use /shop buy (item)");
            }
            else if (_working == "/shop buy Vriend" || _working == "/shop buy vriend")
            {
                if (_money >= 5 * _boughtMultiplierFriend)
                {
                    _money = _money - 5 * _boughtMultiplierFriend;
                    _autoIncome = _autoIncome + 0.5f;
                    _timer = _timer + 1;
                    Console.WriteLine("een Vriend is gekocht en werkt nu voor je");
                    _boughtMultiplierFriend = _boughtMultiplierFriend + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Restaurant" || _working == "/shop buy restaurant")
            {
                if (_money >= 1000 * _boughtMultiplierRestaurant)
                {
                    _money = _money - 1000 * _boughtMultiplierRestaurant;
                    _autoIncome = _autoIncome + 1;
                    _multiplier = _multiplier + 0.5f;
                    _timer = _timer + 1;
                    Console.WriteLine("Restaurant is gekocht en boost je cps");
                    _boughtMultiplierRestaurant = _boughtMultiplierRestaurant + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Fabriek" || _working == "/shop buy fabriek")
            {
                if (_money >= 10000 * _boughtMultiplierFabriek)
                {
                    _money = _money - 10000 * _boughtMultiplierFabriek;
                    _autoIncome = _autoIncome + 10;
                    _multiplier = _multiplier + 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Fabriek is gekocht en boost je cps en multiplier");
                    _boughtMultiplierFabriek = _boughtMultiplierFabriek + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Bank" || _working == "/shop buy bank")
            {
                if (_money >= 100000 * _boughtMultiplierBank)
                {
                    _money = _money - 100000 * _boughtMultiplierBank;
                    _autoIncome = _autoIncome + 100;
                    _timer = _timer + 1;
                    Console.WriteLine("Bank is gekocht en en boost je cps");
                    _boughtMultiplierBank = _boughtMultiplierBank + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy SpaceStation" || _working == "/shop buy spacestation")
            {
                if (_money >= 1000000 * _boughtMultiplierSpaceStation)
                {
                    _money = _money - 1000000 * _boughtMultiplierSpaceStation;
                    _multiplier = _multiplier + 25;
                    _timer = _timer + 1;
                    Console.WriteLine("SpaceStation is gekocht en boost je multiplier");
                    _boughtMultiplierSpaceStation = _boughtMultiplierSpaceStation + 0.2f;
                }
                else
                {
                    Console.WriteLine("je bent te arm voor dit");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Huis" || _working == "/shop buy huis")
            {
                if (_money >= 500 && _maximumBoughtHouse == 0)
                {
                    _money = _money - 500;
                    _multiplier = _multiplier + 1;
                    _maximumBoughtHouse = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Huis is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Straat" || _working == "/shop buy straat")
            {
                if (_money >= 5000 && _maximumBoughtStreet == 0)
                {
                    _money = _money - 5000;
                    _multiplier = _multiplier + 5;
                    _maximumBoughtStreet = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("straat is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Dorp" || _working == "/shop buy dorp")
            {
                if (_money >= 50000 && _maximumBoughtVillage == 0)
                {
                    _money = _money - 50000;
                    _multiplier = _multiplier + 25;
                    _maximumBoughtVillage = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Dorp is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Stad" || _working == "/shop buy stad")
            {
                if (_money >= 250000 && _maximumBoughtCity == 0)
                {
                    _money = _money - 250000;
                    _multiplier = _multiplier + 100;
                    _maximumBoughtCity = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Stad is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Provincie" || _working == "/shop buy provincie")
            {
                if (_money >= 1000000 && _maximumBoughtProvince == 0)
                {
                    _money = _money - 1000000;
                    _multiplier = _multiplier + 500;
                    _maximumBoughtProvince = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Provincie is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Land" || _working == "/shop buy land")
            {
                if (_money >= 10000000 && _maximumBoughtCountry == 0)
                {
                    _money = _money - 10000000;
                    _multiplier = _multiplier + 2500;
                    _maximumBoughtCountry = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Land is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Continent" || _working == "/shop buy continent")
            {
                if (_money >= 100000000 && _maximumBoughtContinent == 0)
                {
                    _money = _money - 100000000;
                    _multiplier = _multiplier + 10000;
                    _maximumBoughtContinent = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Continent is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else if (_working == "/shop buy Wereld" || _working == "/shop buy wereld")
            {
                if (_money >= 1000000000 && _maximumBoughtWorld == 0)
                {
                    _money = _money - 1000000000;
                    _multiplier = _multiplier + 100000;
                    _maximumBoughtWorld = 1;
                    _timer = _timer + 1;
                    Console.WriteLine("Wereld is gekocht");
                }
                else
                {
                    Console.WriteLine("je hebt dit al of je bent te arm");
                    _timer = _timer + 1;
                }
            }
            else
            {
                Console.WriteLine("dit shop item bestaat niet");
                _timer = _timer + 1;
            }
        }
    }
}