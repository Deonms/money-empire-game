using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    // Upgrade dat je muliplier verhoogt.
    internal class MultiplierUpgrade : OvereverenShop
    {
        private float _multiplierAdd;
        private bool _alreadyBought;

        public MultiplierUpgrade(string nameOfItem, float costOfItem, string infoOfItem, float multiplierAdd)
            : base(nameOfItem, costOfItem, infoOfItem)
        {
            _multiplierAdd = multiplierAdd;
            _alreadyBought = false;
        }

        public override void BuyUpgrade(ref float money, ref float multiplier, ref float autoIncome)
        {
            if (_alreadyBought)
            {
                Console.WriteLine("Je hebt dit item al gekocht.");
                return;
            }

            if (money >= _costOfItem)
            {
                money -= _costOfItem;
                multiplier += _multiplierAdd;
                _alreadyBought = true;

                Console.WriteLine($"{_nameOfItem} gekocht!");
            }
            else
            {
                Console.WriteLine("Je hebt niet genoeg geld.");
            }
        }
    }
}
