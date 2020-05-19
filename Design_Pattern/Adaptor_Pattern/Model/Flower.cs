namespace Adaptor_Pattern
{
    public class Flower
    {
        public Flower(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; }
        public Color Color { get; }
    }
}