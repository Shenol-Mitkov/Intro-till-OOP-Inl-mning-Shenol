using IntroTillOOP.Entities;

namespace IntroTillOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            float area = circle.Area(5);
            float area2 = circle.Area(6);
            Console.WriteLine($"Arean är: {area}");
            Console.WriteLine($"Arean är: {area2}");
            Console.ReadLine();
        }

    }
}
