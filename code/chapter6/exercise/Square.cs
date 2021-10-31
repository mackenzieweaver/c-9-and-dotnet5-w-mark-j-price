namespace Shape
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Height = side;
            Width = side;
            Area = Width * Height;
        }
    }
}