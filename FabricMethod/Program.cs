using System;

namespace FabricMethod
{
	// Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания объектов
	// некоторого класса, но непосредственное решение о том, объект какого класса создавать происходит в
	// подклассах. То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.

	// Когда надо применять паттерн:
	// - Когда заранее неизвестно, объекты каких типов необходимо создавать

	// - Когда система должна быть независимой от процесса создания новых объектов и расширяемой:
	//в нее можно легко вводить новые классы, объекты которых система должна создавать.

	// - Когда создание новых объектов необходимо делегировать из базового класса классам наследникам

    class Program
    {
        static void Main(string[] args)
        {
            var messenger = new Messanger("Tom", "rtbvdc");
            messenger.SendMessage("Hello", "Tom", "Alex");

            Console.WriteLine(new string('=', 50));
            
            var twitter = new TwitterMessanger("Tom", "rtbvdc");
            var twit = twitter.CreateMessage("Hello", "Tom", "Alex");
            twit.Send();
            
            Console.WriteLine(new string('=', 50));
            
            var instagram = new InstagramMessanger("Tom", "rtbvdc");
            var photo = instagram.CreateMessage("Profile.jpg", "Tom", "Alex");
            photo.Send();
            
            Console.WriteLine(new string('=', 50));
            
            var telegram = new TelegramMessanger("Tom", "rtbvdc");
            var tele = telegram.CreateMessage("Hello", "Tom", "Alex");
            tele.Send();
            
            
            Console.ReadKey();
        }
    }
}