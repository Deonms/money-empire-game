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
        public List<OvereverenShop> ShoppingList = new List<OvereverenShop>();
        public void AllShopItems()
        {
            OvereverenShop item1 = new OvereverenShop("Vriend", 5, "Boost je auto income met 0.5 \n de prijs gaat na aankoop met 1,2 omhoog");
            ShoppingList.Add(item1);
            OvereverenShop item2 = new OvereverenShop("Restaurant", 1000, "Boost je auto income met 5 \n de prijs gaat na aankoop met 1,2 omhoog");
            ShoppingList.Add(item2);
            OvereverenShop item3 = new OvereverenShop("Fabriek", 10000, "Boost je auto income met 10 en multiplier met 1 \n de prijs gaat na aankoop met 1,2 omhoog");
            ShoppingList.Add(item3);
            OvereverenShop item4 = new OvereverenShop("Bank", 100000, "Boost je auto income met 100 \n de prijs gaat na aankoop met 1,2 omhoog");
            ShoppingList.Add(item4);
            OvereverenShop item5 = new OvereverenShop("SpaceStation", 1000000, "Boost je multiplier met 25 \n de prijs gaat na aankoop met 1,2 omhoog");
            ShoppingList.Add(item5);
            OvereverenShop item6 = new OvereverenShop("Huis", 500, "dit doet niet zo veel maar multiplier + 1 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item6);
            OvereverenShop item7 = new OvereverenShop("Straat", 5000, "dit doet niet zo veel maar multiplier + 5 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item7);
            OvereverenShop item8 = new OvereverenShop("Dorp", 50000, "dit doet niet zo veel maar multiplier + 25 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item8);
            OvereverenShop item9 = new OvereverenShop("Stad", 250000, "dit doet niet zo veel maar multiplier + 1000 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item9);
            OvereverenShop item10 = new OvereverenShop("Provincie", 1000000, "dit doet niet zo veel maar multiplier + 500 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item10);
            OvereverenShop item11 = new OvereverenShop("Land", 10000000, "dit doet niet zo veel maar multiplier + 2500 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item11);
            OvereverenShop item12 = new OvereverenShop("Continent", 100000000, "dit doet niet zo veel maar multiplier + 10000 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item12);
            OvereverenShop item13 = new OvereverenShop("Wereld", 1000000000, "dit doet niet zo veel maar multiplier + 100000 \n je kan dit niet opnieuw kopen");
            ShoppingList.Add(item13);

        }
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem) : base(nameOfItem, costOfItem, infoOfItem)
        {
            _nameOfItem = nameOfItem;
            _costOfItem = costOfItem;
            _infoOfItem = infoOfItem;
        }

        public void BuyItem(string itemName, ref float money, ref float multiplier, ref float autoIncome)
        {
            foreach (OvereverenShop item in ShoppingList)
            {
                if (item.GetName().ToLower() == itemName.ToLower())
                {
                    item.BuyUpgrade(ref money, ref multiplier, ref autoIncome);
                    return;
                }
            }

            Console.WriteLine("Dit shop item bestaat niet.");
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
