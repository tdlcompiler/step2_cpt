namespace OOP_2
{
    public class Bicycle : Vehicle
    {
        private int _speedCount;

        public Bicycle(string name, int maxSpeed, int speedCount) : base(name, maxSpeed)
        {
            SpeedCount = speedCount;
        }

        public int SpeedCount
        {
            get { return _speedCount; }
            set { if (value > 0) _speedCount = value; }
        }

        public override string GetDump()
        {
            return $"Bicycle {base.GetDump()} SpeedCount = {SpeedCount}.";
        }
    }
}
