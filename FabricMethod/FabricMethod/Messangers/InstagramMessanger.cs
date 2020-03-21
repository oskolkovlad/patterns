using System;

namespace FabricMethod
{
    public class InstagramMessanger : MessangerBase
    {
        public InstagramMessanger(string name, string password)
            : base(name, password) { }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            return new InstagramMessage(text, source, target);
        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация пользователя в Instagram с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}