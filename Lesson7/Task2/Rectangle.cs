using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    public class Rectangle:Figure
    {
        private int _a;
        private int _b;
        public int A
        {
            get
            {
                return _a;
            }
            private set
            {
                _a = GetValidSize(value);
            }
        }
        public int B
        {
            get
            {
                return _b;
            }
            private set
            {
                _b = GetValidSize(value);
            }
        }

        public Rectangle(int width,int length,Color color, BasePoint basePoint)
        {
            A = width;
            B = length;
            Color = color;
            BasePoint = basePoint;
        }
        public double GetArea()
        {
            return _a * _b;
        }
    }
}
