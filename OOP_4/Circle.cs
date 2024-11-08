namespace OOP_4
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Radius
        {
            get { return _radius; }
            set { if (value > 0) _radius = value; }
        }

        public override float GetArea()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
