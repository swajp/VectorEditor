using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VectorEditor_IT3B
{
    public class Circle : Shape
    {
        //Point - CenterPoint, int - Radius, color - Color
        public Point CenterPoint { get; set; }
        public Color Color { get; set; }
        public int Radius{ get; set; }
        public int CircleWidth { get; set; }


        public Circle(Point centerPoint, int radius)
        {
            CenterPoint = centerPoint;
            Color = Color.Black;
            Radius = radius;
            CircleWidth = 1;
        }

        public Circle(Point centerPoint,Color color, int circleWidth, int radius)
        {
            CenterPoint = centerPoint;
            Color = color;
            Radius = radius;
            CircleWidth = circleWidth;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color, CircleWidth), CenterPoint.X - 20, CenterPoint.Y - 20, Radius, Radius);
        }
    }
}
