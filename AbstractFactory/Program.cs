using System;
using AbstractFactory.BaseImplemention;

namespace AbstractFactory
{
    // Паттерн "Абстрактная фабрика" (Abstract Factory) предоставляет интерфейс для создания семейств взаимосвязанных
    // объектов с определенными интерфейсами без указания конкретных типов данных объектов.

    //Когда использовать абстрактную фабрику
    // - Когда система не должна зависеть от способа создания и компоновки новых объектов
    // - Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
    class Program
    {
        static void Main(string[] args)
        {
            // Простая реализация
            var body = new Body("Priora", 1.0, 100000, 2000, 300);
            var engine = new Engine("v8", 200, 150000, 200);
            var tank = new Tank("Standard", 48, 30000, 40);
            var priora = new Car(body, engine, tank);
            Console.WriteLine($"Priora: {priora} | {priora.Price} | {priora.Weight} | {priora.Body.Name} | {priora.Engine.Name}\n");
            


            // Реализация абстрактной фабрики на простой реализации
            Auto car = new Auto(new CarFactory());
            Auto truck = new Auto(new TruckFactory());
            Console.WriteLine($"Car: {car} | {car.Price} | {car.Weight} | {car.Body.Name} | {car.Engine.Name}\n");
            Console.WriteLine($"Car: {truck} | {truck.Price} | {truck.Weight} | {truck.Body.Name} | {truck.Engine.Name}");


            Console.ReadKey();
        }
    }
}