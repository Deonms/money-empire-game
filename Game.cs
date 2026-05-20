using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    
    internal class Game
    {
        private EaningMoney _earnmoneys = new EaningMoney();

        public void start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine($"Type work to earn money");
                Console.WriteLine($"Type /shop help to see what the shop sells");
                _earnmoneys.Earnmoney();
            }
        }
    }
}
