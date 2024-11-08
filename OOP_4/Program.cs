namespace OOP_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, CPT!");

            Shape circle = new Circle(radius: 228);
            Console.WriteLine($"Площадь окружности = {circle.GetArea()}.");

            Shape rect = new Rectangle(width: 10, height: 0.9f);
            Console.WriteLine($"Площадь прямоугольника = {rect.GetArea()}.");
        }
    }
}
