using System;

namespace AbstractFactory.BaseImplemention
{
    public class Auto
    {
        public AutoBody   Body   { get; }
        public AutoEngine Engine { get; }
        public AutoTank   Tank   { get; }
        
        public string  Vin    => Guid.NewGuid().ToString();

        public decimal Price
        {
            get
            {
                if (Body is null && Engine is null && Tank is null)
                    return 0;
                else
                {
                    return Body.Price + Engine.Price + Tank.Price;
                }
            }
        }
        
        public double  Weight{
            get
            {
                if (Body is null && Engine is null && Tank is null)
                    return 0;
                else
                {
                    return Body.Weight + Engine.Weight + Tank.Weight;
                }
            }
        }

        public Auto(AutoFactory factory)
        {
            Body   = factory.CreateBody();
            Engine = factory.CreateEngine();
            Tank   = factory.CreateTank();
        }

        public override string ToString()
        {
            return Vin;
        }
    }
}