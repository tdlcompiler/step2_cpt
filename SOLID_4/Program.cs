namespace SOLID_4
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
    }

    public class PrinterOnly : IPrinter
    {
        public void Print() => Console.WriteLine("Printing...");
    }

    class Program
    {
        static void Main()
        {
            IPrinter printer = new PrinterOnly();
            printer.Print();

            IScanner scanner = new MultiFunctionPrinter();
            scanner.Scan();
            ((IPrinter)scanner).Print();
        }
    }
}
