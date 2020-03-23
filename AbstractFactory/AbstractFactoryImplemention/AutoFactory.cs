namespace AbstractFactory.BaseImplemention
{
    public abstract class AutoFactory
    {
        public abstract AutoBody   CreateBody();
        public abstract AutoEngine CreateEngine();
        public abstract AutoTank   CreateTank();
    }
}