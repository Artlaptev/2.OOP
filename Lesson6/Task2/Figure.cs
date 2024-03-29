﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task2
{
    public class Figure
    {
        public Color Color { get; set; }
        public bool IsVisible { get; set; }
        public BasePoint BasePoint { get; protected set; }
        
        public void MoveHorisontal(int inkrement)
        {
            BasePoint.X += inkrement;
        }
        public void MoveVertical(int inkrement)
        {
            BasePoint.X += inkrement;
        }
        public static int GetValidSize(int size)
        {
            if (size > 0 && size is int) return size;
            else throw new ArgumentException("Неверный формат");
        }

    }
}
