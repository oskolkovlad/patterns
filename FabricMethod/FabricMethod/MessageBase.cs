using System;

namespace FabricMethod
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }
        public string Source { get; }
        public string Target { get; }

        public MessageBase(string text, string source, string target)
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
            
            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();
    }
}