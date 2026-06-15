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
        private string _nameOfItem;
        private float _costOfItem;
        private string _infoOfItem;
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        public void AllShopItems()
        {
            OvereverenShop item1 = new OvereverenShop("string", 5, "speciale info");
            ShoppingList.Add(item1);
        }
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem) : base(nameOfItem, costOfItem, infoOfItem)
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
