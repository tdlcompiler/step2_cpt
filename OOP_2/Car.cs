namespace OOP_2
{
    public class Car : Vehicle
    {
        private int _horsepower;

        public Car(string name, int maxSpeed, int horsepower) : base(name, maxSpeed)
        {
            HorsePower = horsepower;
        }

        public int HorsePower
        {
            get { return _horsepower; }
            set { if (value > 0) _horsepower = value; }
        }

        public override string GetDump()
        {
            return $"Car {base.GetDump()} HorsePower = {HorsePower}.";
        }
    }
}
