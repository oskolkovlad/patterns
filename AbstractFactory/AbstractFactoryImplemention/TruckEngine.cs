namespace AbstractFactory.BaseImplemention
{
    public class TruckEngine : AutoEngine
    {
        public TruckEngine() { }
        
        /*public TruckEngine(string name, double maxSpeed, decimal price, double weight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
            Weight = weight;
        }*/

        public override string  Name => "Daimler OM 457LA";
        public override decimal Price => 2000000;
        public override double Weight => 1500;
        public override double  MaxSpeed => 110;

        
        public override string ToString()
        {
            return Name;
        }
    }
}