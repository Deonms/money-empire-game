using System;
namespace Money_Empire_Game
{
    internal class OneTimeItem : OvereverenShop
    {
        public bool IsBought = false;

        public OneTimeItem(string nameOfItem, float costOfItem, string infoOfItem, float multiplierAdd, float autoIncome) : base(nameOfItem, costOfItem, infoOfItem, multiplierAdd, autoIncome)
        {
        }
    }
}
