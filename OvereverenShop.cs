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
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        private string _nameOfItem;
        private float _costOfItem;
        private string _infoOfItem;
        private float _multiplierAdd;
        private float _autoIncome;

        

        public OvereverenShop(string nameOfItem, float costOfItem, string infoOfItem)
        {
            _nameOfItem = nameOfItem;
            _costOfItem = costOfItem;
            _infoOfItem = infoOfItem;
        }
        public void ShowItem()
        {
            Console.WriteLine($"{_nameOfItem} \n het kost: {_costOfItem} \n {_infoOfItem}");
        }

        public void SeeShop()
        {
            foreach (OvereverenShop item in ShoppingList)
            {
                item.ShowItem();
            }
        }

        public virtual void BuyUpgrade()
        {

        }
    }
}
