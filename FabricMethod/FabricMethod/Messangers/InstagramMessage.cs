using System;
using System.IO;

namespace FabricMethod
{
    public class InstagramMessage : MessageBase
    {
        public InstagramMessage(string text, string source, string target)
            : base(text, source, target)
        {
            if (File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }

        public override void Send()
        {
            Console.WriteLine($"Instagram: фото от {Source} для {Target} - {Text}");
        }
    }
}