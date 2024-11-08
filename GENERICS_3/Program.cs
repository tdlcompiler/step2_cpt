namespace GENERICS_3
{
    public class Repository<T> where T : class
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
        static void Main()
        {
            var repo = new Repository<string>();
            repo.Add("строчка");
            Console.WriteLine(repo.Get(0));
        }
    }

}
