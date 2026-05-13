using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Cat : Animals
    {
        private int _lengthTail;
        public Cat(string name, int lengthTail) : base(name)
        {
            _lengthTail = lengthTail;
        }
        public void Miauw()
        {
            Console.WriteLine($"i have a {_lengthTail} cm long");
            Console.WriteLine("Miauw");
            
        }
        public void Zeuren()
        {
            Console.WriteLine($"i have a {_lengthTail} cm long");
            Console.WriteLine("Zeuren");
        }
    }
}
