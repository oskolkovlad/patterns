using System;

namespace AbstractFactory.BaseImplemention
{
    public class CarFactory : AutoFactory
    {
        public override AutoBody CreateBody()
        {
            return new CarBody();
        }

        public override AutoEngine CreateEngine()
        {
            return new CarEngine();
        }

        public override AutoTank CreateTank()
        {
            return new CarTank();
        }
    }
}