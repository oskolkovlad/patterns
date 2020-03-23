namespace AbstractFactory.BaseImplemention
{
    public class CarEngine : AutoEngine
    {
        public CarEngine() { }
        
        /*public CarEngine(string name, double maxSpeed, decimal price, double weight)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
            Weight = weight;
        }*/
        
        public override string  Name => "Двигатель ВАЗ-1111";
        public override decimal Price => 50000;
        public override double Weight => 250;
        public override double  MaxSpeed => 80;

        
        public override string ToString()
        {
            return Name;
        }
    }
}