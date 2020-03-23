namespace AbstractFactory.BaseImplemention
{
    public class Tank
    {
        public string Name { get; }
        public double MaxVolume { get; }
        public decimal Price { get; }
        public double Weight { get; }

        public Tank(string name, double maxVolume, decimal price, double weight)
        {
            Name = name;
            MaxVolume = maxVolume;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}