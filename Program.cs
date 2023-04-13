namespace OOpShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);
            Square square2 = new Square(2);

            Console.WriteLine($"Area of the square: {square1.GetArea()}");
        }
    }
}