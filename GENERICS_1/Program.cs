namespace GENERICS_1
{
    public class Pair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }
    }

    class Program
    {
        static void Main()
        {
            var pair = new Pair<int, string>(1, "один");
            Console.WriteLine($"Пара {pair.First}:{pair.Second}");
            pair.First = 12;
            pair.Second = "двенадцать";
            Console.WriteLine($"Изменённая пара {pair.First}:{pair.Second}");
        }
    }
}
