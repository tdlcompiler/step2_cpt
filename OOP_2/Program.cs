namespace OOP_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, CPT!");

            Vehicle simpleVehicle = new("эточозааппарат", 100000);
            Console.WriteLine(simpleVehicle.GetDump());

            Car car = new("lamba", 400, 1000);
            Console.WriteLine(car.GetDump());

            Bicycle bicycle = new("BMX", 50, 1);
            Console.WriteLine(bicycle.GetDump());
        }
    }
}
