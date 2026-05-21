using System;
using System.Collections.Generic;
namespace Money_Empire_Game
{
    internal class AutoIncomeItem : OvereverenShop
    {
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        public AutoIncomeItem(string nameOfItem, float costOfItem, string infoOfItem, float multiplierAdd, float autoIncome) : base(nameOfItem, costOfItem, infoOfItem, multiplierAdd, autoIncome)
        {
        }
    }
}