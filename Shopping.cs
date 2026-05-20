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
        public Shopping(string nameOfItem, float costOfItem, string infoOfItem) : base(nameOfItem, costOfItem, infoOfItem)
        {

        }

        public void shops()
        {

        }
    }
}
