using System;

namespace FabricMethod
{
    public class TelegramMessanger : MessangerBase
    {
        public TelegramMessanger(string name, string password)
            : base(name, password) { }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            return new TelegramMessage(text, source, target);
        }

        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация пользователя в Telegram с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}