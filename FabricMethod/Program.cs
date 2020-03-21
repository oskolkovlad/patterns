using System;

namespace FabricMethod
{
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