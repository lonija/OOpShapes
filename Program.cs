namespace OOpShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);
            Square square2 = new Square(2);
            Circle circle1 = new Circle(3);
            Triangle triangle = new Triangle(3, 4);

            Console.WriteLine($"Area of the square: {square1.GetArea()}");
            Console.WriteLine($"Area of the square: {square2.GetArea()}");

            Console.WriteLine($"Area of the circle {circle1.GetArea()}");
            Console.WriteLine($"triagle area  {triangle.GetArea()}");
        }
    }
}