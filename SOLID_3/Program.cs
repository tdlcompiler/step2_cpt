namespace SOLID_3
{
    public abstract class Bird
    {
        public abstract string MoveToMe();
    }

    public class FlyingBird : Bird
    {
        public override string MoveToMe()
        {
            return "Я лечу к тебе!";
        }
    }

    public class Penguin : Bird
    {
        public override string MoveToMe()
        {
            return "Я бегу к тебе!";
        }
    }

    public class Program
    {
        public static void PrintComeToMe(Bird bird)
        {
            Console.WriteLine(bird.MoveToMe());
        }

        public static void Main()
        {
            Bird flyingBird = new FlyingBird();
            Bird penguin = new Penguin();

            PrintComeToMe(flyingBird);
            PrintComeToMe(penguin);
        }
    }
}
