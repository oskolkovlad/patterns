using System;

namespace FabricMethod
{
    public class Message
    {
        public Message(string text, string source, string target)
        {
            #region Проверка на корректность данных

            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Сообщение не может быть пустым.");
            }
            
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Отправитель не может быть пустым.");
            }
            
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "Получатель не может быть пустым.");
            }
            
            #endregion
            
            if (text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            
            Source = source;
            Target = target;
        }

        public string Text { get; private set; }
        public string Source { get; private set; }
        public string Target { get; private set; }
    }
}