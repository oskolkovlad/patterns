namespace AbstractFactory.BaseImplemention
{
    public class CarBody : AutoBody
    {
        public CarBody() { }
        
        /*public CarBody(string name, double aerodynamic, decimal price, double weight, double maxWeight)
        {
            Name = name;
            Aerodynamic = aerodynamic;
            Price = price;
            Weight = weight;
            MaxWeight = maxWeight;
        }*/
        
        public override string  Name => "Корпус ВАЗ-1111";
        public override decimal Price => 30000;
        public override double  Weight => 350;
        public override double  Aerodynamic => 1.1;
        public override double  MaxWeight => 985;

        
        public override string ToString()
        {
            return Name;
        }
    }
}