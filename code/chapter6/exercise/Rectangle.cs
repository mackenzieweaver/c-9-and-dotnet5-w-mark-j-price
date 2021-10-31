namespace Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            Area = Width * Height;
        }
    }
}