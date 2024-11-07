namespace OOP_2
{
    public class Vehicle
    {
        private string? _name;
        private int _maxSpeed = 0;

        public Vehicle(string name, int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            Name = name;
        }

        public string Name
        {
            get { return _name ?? "Empty Name"; }
            set { _name = value; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { if (value > 0) _maxSpeed = value; }
        }

        public virtual string GetDump()
        {
            return $"vehicle \"{Name}\": Max Speed = {MaxSpeed}.";
        }
    }
}