using System;
using System.Collections.Generic;
namespace Money_Empire_Game
{
    internal class OneTimeItem : OvereverenShop
    {
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        public bool IsBought = false;

        public OneTimeItem(string nameOfItem, float costOfItem, string infoOfItem, float multiplierAdd, float autoIncome) : base(nameOfItem, costOfItem, infoOfItem, multiplierAdd, autoIncome)
        {
        }
    }
}
