namespace GENERICS_5
{
    public interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
    }

    public class ListStorage<T> : IStorage<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T Get(int index)
        {
            return _items[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ListStorage<int>();
            storage.Add(42);
            Console.WriteLine($"Первый элемент коллекции: {storage.Get(0)}");
        }
    }
}
