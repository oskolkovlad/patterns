using System.IO;

namespace Singleton
{
    /// <summary>
    /// Класс для работы с текстом.
    /// </summary>
    public class FileWorker
    {
        /// <summary>
        /// Создание нового объекта для работы с текстом.
        /// </summary>
        public FileWorker()
        {
            FilePath = "text.txt";
            ReadTextFromFile();
        }
        
        public FileWorker(string path)
        {
            FilePath = path;
            ReadTextFromFile();
        }
        
        /// <summary>
        /// Путь к файлу записи.
        /// </summary>
        public string FilePath { get; private set; }
        
        /// <summary>
        /// Содержимое файла в динамической памяти.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Прочитать данные из файла.
        /// </summary>
        public void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var sr = new StreamReader(FilePath))
                {
                    Text = sr.ReadToEnd();
                }
            }
        }
        
        /// <summary>
        /// Добавить текст в файл без сохранения в динамическую память.
        /// </summary>
        /// <param name="text">Добавляемый текст.</param>
        public void WriteText(string text)
        {
            Text += text;
        }
        
        /// <summary>
        /// Сохранение текста в файл.
        /// </summary>
        public void Save()
        {
            using (var sw = new StreamWriter(FilePath, false))
            {
                sw.WriteLine(Text);
            }
        }
    }
}