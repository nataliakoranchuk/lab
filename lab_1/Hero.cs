using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Hero
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;
        public char Symbol { get; set; } = 'x';
        public int Money { get; set; } = 0;

        private static Hero _hero;
        public static Hero GetHero
        {
            get
            {
                if (_hero == null)
                {
                    _hero = new Hero();
                }
                return _hero;
            }
        }
        private Hero() { }
    }
}
