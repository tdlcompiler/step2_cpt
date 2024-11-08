namespace GENERICS_4
{
    public class Swapper
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            (second, first) = (first, second);
        }
    }

    class Program
    {
        static void Main()
        {
            int a = 5, b = 10;
            Console.WriteLine($"До свапа: a = {a}, b = {b}");
            Swapper.Swap(ref a, ref b);
            Console.WriteLine($"После свапа: a = {a}, b = {b}");
        }
    }
}
