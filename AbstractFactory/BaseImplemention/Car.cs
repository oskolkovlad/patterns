using System;

namespace AbstractFactory.BaseImplemention
{
    public class Car
    {
        public Body   Body { get; }
        public Engine Engine { get; }
        public Tank   Tank { get; }

        public string  Vin   => Guid.NewGuid().ToString();
        public decimal Price => Body.Price + Engine.Price + Tank.Price;
        public double Weight => Body.Weight + Engine.Weight + Tank.Weight;

        public Car(Body body, Engine engine, Tank tank)
        {
            Body   = body;
            Engine = engine;
            Tank   = tank;
        }

        public override string ToString()
        {
            return Vin;
        }
    }
}