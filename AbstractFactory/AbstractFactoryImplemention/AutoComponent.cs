namespace AbstractFactory.BaseImplemention
{
    public abstract class AutoComponent
    {
        public abstract string  Name { get; }
        public abstract decimal Price { get; }
        public abstract double  Weight { get; }
    }
}