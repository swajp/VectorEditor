using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VectorEditor_IT3B
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics graphics);
    }
    public enum Shapes
    {
        None,
        Point,
        Line,
        Circle
    }
}
