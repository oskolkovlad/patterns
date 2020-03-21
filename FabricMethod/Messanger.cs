using System;

namespace FabricMethod
{
    public class Messanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }

        public Messanger(string name, string password)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(password))
            {
                UserName = name;
                Password = password;
                Connected = ConnectedToTwitter();
            }
            else
            {
                Connected = false;
            }
        }

        public void SendMessage(string text, string source, string target)
        {
            var message = new Message(text, source, target);
            SendMessageToTwitter(message);
        }

        private void SendMessageToTwitter(Message message)
        {
            // TODO: Обращение с API Twitter

            Console.WriteLine($"Twitter: {message.Text}");
        }

        private bool ConnectedToTwitter()
        {
            // TODO: Обращение с API Twitter

            Console.WriteLine($"Авторизпция пользователя с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}