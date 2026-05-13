using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Work
    {
        Cat cleo = new Cat("Cleo", 10);

        Cat wheezy = new Cat("Wheezy", 8);
        public void start()
        {
            cleo.SayName();
            cleo.Zeuren();
            cleo.Sleep();
            wheezy.SayName();
            wheezy.Miauw();
            wheezy.Sleep();
        }


    }
}
