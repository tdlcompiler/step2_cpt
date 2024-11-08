namespace OOP_4
{
    public class Rectangle : Shape
    {
        private float _width;
        private float _height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float Width
        {
            get { return _width; }
            set { if (value > 0) _width = value; }
        }

        public float Height
        {
            get { return _height; }
            set { if (value > 0) _height = value; }
        }

        public override float GetArea()
        {
            return Width * Height;
        }
    }
}
