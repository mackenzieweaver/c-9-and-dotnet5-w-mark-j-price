using System;

namespace Shape
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = radius * 2;
            Width = radius * 2;
            Area = Math.PI * radius * radius;
        }
    }
}