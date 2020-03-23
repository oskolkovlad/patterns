namespace AbstractFactory.BaseImplemention
{
    public class CarTank : AutoTank
    {
        public CarTank() { }

        /*public CarTank(string name, double maxVolume, decimal price, double weight)
        {
            Name = name;
            MaxVolume = maxVolume;
            Price = price;
            Weight = weight;
        }*/
        
        public override string  Name => "Бак ВАЗ-1111";
        public override decimal Price => 20000;
        public override double  Weight => 45;
        public override double  MaxVolume => 30;

        
        public override string ToString()
        {
            return Name;
        }
    }
}