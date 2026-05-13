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
        List<Shopping> ShoppingList = new List<Shopping>();
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem) : base(nameOfItem, costOfItem, infoOfItem)
        {

        }
        public void shops()
        {

        }
    }
}
