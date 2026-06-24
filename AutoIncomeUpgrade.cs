using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    // Upgrade dat auto income hoger maakt.
    internal class AutoIncomeUpgrade : OvereverenShop
    {
        private float _autoIncomeAdd;
        private float _priceMultiplier = 1;

        public AutoIncomeUpgrade(string nameOfItem, float costOfItem, string infoOfItem, float autoIncomeAdd)
            : base(nameOfItem, costOfItem, infoOfItem)
        {
            _autoIncomeAdd = autoIncomeAdd;
        }

        public override void BuyUpgrade(ref float money, ref float multiplier, ref float autoIncome)
        {
            float realCost = _costOfItem * _priceMultiplier;

            if (money >= realCost)
            {
                money -= realCost;
                autoIncome += _autoIncomeAdd;
                _priceMultiplier += 0.2f;

                Console.WriteLine($"{_nameOfItem} gekocht!");
            }
            else
            {
                Console.WriteLine("Je hebt niet genoeg geld.");
            }
        }
    }
}
