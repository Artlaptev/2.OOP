using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    public class Circle:Point
    {
        private int r;
        public int R {
            get
            {
                return r;
            }
            private set
            {
                r = GetValidSize(value);
            }
        }

        public Circle(int size,Color color, BasePoint basePoint )
        {
            R = size;
            Color= color;
            BasePoint= basePoint;
        }
        public double GetArea()
        {
            return Math.PI * R *R;
        }
    }
}
