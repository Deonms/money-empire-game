using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Empire_Game
{
    internal class Animals
    {
        private string _eyeColor;
        public string EyeColor;
        protected string EyeColor2
        {
            get => _eyeColor;
            private set
            {
                _eyeColor = value;
            }
        }
    }
}
