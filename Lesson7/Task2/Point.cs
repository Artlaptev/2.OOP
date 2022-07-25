using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Point:Figure
    {
        public BasePoint BasePoint { get; protected set; }
        public void MoveHorisontal(int inkrement)
        {
            BasePoint.X += inkrement;
        }
        public void MoveVertical(int inkrement)
        {
            BasePoint.X += inkrement;
        }
    }
}
