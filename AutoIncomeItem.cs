using System;
namespace Money_Empire_Game
{
    internal class AutoIncomeItem : OvereverenShop
    {
        public AutoIncomeItem(string nameOfItem, float costOfItem, string infoOfItem, float multiplierAdd, float autoIncome) : base(nameOfItem, costOfItem, infoOfItem, multiplierAdd, autoIncome)
        {
        }
    }
}