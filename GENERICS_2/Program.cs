namespace GENERICS_2
{
    public class MinFinder
    {
        public static T FindMin<T>(T[] array) where T : IComparable
        {
            T minValue = array[0];
            foreach (var item in array)
            {
                if (item.CompareTo(minValue) < 0)
                    minValue = item;
            }
            return minValue;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] intArray = [5, 1, 9, 2];
            Console.WriteLine($"Минимальное значение: {MinFinder.FindMin(intArray)}");

            float[] floatList = [123.6f, -12.99f, 0.6f];
            Console.WriteLine($"Минимальное значение: {MinFinder.FindMin(floatList)}");
        }
    }
}