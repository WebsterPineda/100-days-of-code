namespace BasisOOP.Classes
{
    public class Square : BaseShape
    {
        public Square(double width, double height) : base(width, height) {}

        public override double Area()
        {
            return width * height;
        }
    }
}