namespace AbstractFactory.BaseImplemention
{
    public class TruckBody : AutoBody
    {
        public TruckBody() { }
        
        /*public TruckBody(string name, double aerodynamic, decimal price, double weight, double maxWeight)
        {
            Name = name;
            Aerodynamic = aerodynamic;
            Price = price;
            Weight = weight;
            MaxWeight = maxWeight;
        }*/
        
        public override string  Name => "Корпус KAMAZ-5490";
        public override decimal Price => 1500000;
        public override double  Weight => 1000;
        public override double  Aerodynamic => 0.7;
        public override double  MaxWeight => 7900;

        
        public override string ToString()
        {
            return Name;
        }
    }
}