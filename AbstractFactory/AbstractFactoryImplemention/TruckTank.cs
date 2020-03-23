namespace AbstractFactory.BaseImplemention
{
    public class TruckTank : AutoTank
    {
        public TruckTank() { }

        /*public TruckTank(string name, double maxVolume, decimal price, double weight)
        {
            Name = name;
            MaxVolume = maxVolume;
            Price = price;
            Weight = weight;
        }*/
        
        public override string  Name => "Бак KAMAZ-5490";
        public override decimal Price => 300000;
        public override double  Weight => 200;
        public override double  MaxVolume => 800;

        
        public override string ToString()
        {
            return Name;
        }
    }
}