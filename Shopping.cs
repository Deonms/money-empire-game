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
        string _nameOfItem;
        float _costOfItem;
        string _infoOfItem;
        public List<Shopping> ShoppingList = new List<Shopping>();
        public void AllShopItems()
        {
            Shopping item1 = new Shopping("String", 16, "Very good info", 0, 0);
            ShoppingList.Add(item1);
        }
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem, float multiplieradd, float autoincome) : base(nameOfItem, costOfItem, infoOfItem, multiplieradd, autoincome)
        {
            _nameOfItem = nameOfItem;
            _costOfItem = costOfItem;
            _infoOfItem = infoOfItem;
        }

        public void shops()
        {

        }
        public void buying()
        {
            if (_money >= _costOfItem)
            {
                _money = _money - _costOfItem;
            }
        }
    }
}
