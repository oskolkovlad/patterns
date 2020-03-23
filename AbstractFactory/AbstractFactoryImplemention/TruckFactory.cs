using System;

namespace AbstractFactory.BaseImplemention
{
    public class TruckFactory : AutoFactory
    {
        public override AutoBody CreateBody()
        {
            return new TruckBody();
        }

        public override AutoEngine CreateEngine()
        {
            return new TruckEngine();
        }

        public override AutoTank CreateTank()
        {
            return new TruckTank();
        }
    }
}