using System;

namespace FabricMethod
{
    public class TelegramMessage : MessageBase
    {
        public TelegramMessage(string text, string source, string target)
            : base(text, source, target)
        {
            Text = text;
        }

        public override void Send()
        {
            Console.WriteLine($"Telegram: сообщение от {Source} для {Target} - {Text}");
        }
    }
}