namespace AbstractFactory.BaseImplemention
{
    public class Engine
    {
        public string Name { get; }
        public double MaxSpeed { get; }
        public decimal Price { get; }
        public double Weight { get; }

        public Engine(string name, double maxSpeed, decimal price, double weight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}