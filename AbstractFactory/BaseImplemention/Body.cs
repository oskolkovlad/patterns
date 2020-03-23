namespace AbstractFactory.BaseImplemention
{
    public class Body
    {
        public string Name { get; }
        public double Aerodynamic { get; }
        public decimal Price { get; }
        public double Weight { get; }
        public double MaxWeight { get; }

        public Body(string name, double aerodynamic, decimal price, double weight, double maxWeight)
        {
            Name = name;
            Aerodynamic = aerodynamic;
            Price = price;
            Weight = weight;
            MaxWeight = maxWeight;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}