using System;

namespace FabricMethod
{
    public class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string name, string password)
            : base(name, password) { }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            return new TwitterMessage(text, source, target);
        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация пользователя в Twitter с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}