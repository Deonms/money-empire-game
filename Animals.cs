using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Animals
    {
        public Animals(string name)
        {
            _name = name;
        }

        private string _eyeColor;
        //public string EyeColor;
        protected string EyeColor2
        {
            get => _eyeColor;
            private set
            {
                _eyeColor = value;
            }
        }
       // protected string SkinColor;
        private string _name;

        public void Sleep()
        {
            Console.WriteLine("SNURK");
        }
        public void SayName()
        {
            Console.WriteLine(_name);
        }
    }
}
