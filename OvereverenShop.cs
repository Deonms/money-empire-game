using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Money_Empire_Game
{
    internal class OvereverenShop
    {
        List<Shopping> ShoppingList = new List<Shopping>();
        private string _nameOfItem;
        private float _costOfItem;
        private string _infoOfItem;

        public OvereverenShop(string nameOfItem, float costOfItem, string infoOfItem)
        {
            _nameOfItem = nameOfItem;
            _costOfItem = costOfItem;
            _infoOfItem = infoOfItem;
        }
        public void SeeShop()
        {
            Console.WriteLine($"{_nameOfItem} \n het kost: {_costOfItem} \n {_infoOfItem}");
        }
    }
}
