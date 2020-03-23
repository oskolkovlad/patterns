namespace AbstractFactory.BaseImplemention
{
    public abstract class AutoBody : AutoComponent
    {
        public abstract double Aerodynamic { get; }
        public abstract double MaxWeight { get; }
    }
}