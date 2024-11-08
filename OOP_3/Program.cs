namespace OOP_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, CPT!");

            Animal baseAnimal = new Animal();
            baseAnimal.MakeSound();

            Liberal liberalAnimal = new Liberal();
            liberalAnimal.MakeSound();

            Shaman shamanOneLove = new Shaman();
            shamanOneLove.MakeSound();
        }
    }
}
