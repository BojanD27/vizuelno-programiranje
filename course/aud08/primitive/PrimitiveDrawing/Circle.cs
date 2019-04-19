﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDrawing
{
    public class Circle : Shape
    {
        public int Radius{ get; set; }

        public Circle(float x, float y) : base(x, y) {
            Radius = 30;
        }

        public override void draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
    }
}
