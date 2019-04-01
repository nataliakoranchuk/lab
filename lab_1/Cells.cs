using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Cells
    {
        public int X { get; set; }
        public int Y { get; set; }

        public char Symbol { get; set; }

        public Cells(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
