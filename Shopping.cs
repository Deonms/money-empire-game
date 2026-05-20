using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Shopping : OvereverenShop
    {
        private string _working;
        private float _money;
        private float _multiplier = 1;
        public List<Shopping> ShoppingList = new List<Shopping>();
        public void AllShopItems()
        {
            Shopping item1 = new Shopping("String", 16, "Very good info");
            ShoppingList.Add(item1);
        }
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem) : base(nameOfItem, costOfItem, infoOfItem)
        {

        }

        public void shops()
        {

        }
    }
}
