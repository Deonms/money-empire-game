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
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        public void AllShopItems()
        {
            ShoppingList.Add(new AutoIncomeItem("Vriend", 100, "Auto income +1/s", 0, 1));
            ShoppingList.Add(new AutoIncomeItem("Bakkerij", 10000, "Auto income +10/s", 0, 10));
            ShoppingList.Add(new AutoIncomeItem("Fabriek", 10000000, "Auto income +100/s", 0, 100));
            ShoppingList.Add(new OneTimeItem("Beter ovens", 25000, "Multiplier +0.5", 0.5f, 0));
            ShoppingList.Add(new OneTimeItem("Iets Beter ingredienten", 100, "Multiplier +0.125", 0.125f, 0));
            ShoppingList.Add(new OneTimeItem("Beter ingredienten", 1000, "Multiplier +0.25", 0.25f, 0));
            ShoppingList.Add(new OneTimeItem("Beter werk ruimte", 100000, "Multiplier +0.75", 0.75f, 0));
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
