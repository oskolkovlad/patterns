using System;
using System.IO;


// Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для определенного класса будет создан
// только один объект, а также предоставит к этому объекту точку доступа.

// Когда надо использовать Синглтон? Когда необходимо, чтобы для класса существовал только один экземпляр.

// Синглтон позволяет создать объект только при его необходимости. Если объект не нужен, то он не будет создан.
// В этом отличие синглтона от глобальных переменных.
namespace Singleton
{
    /// <summary>
    /// Класс для работы с текстом.
    /// </summary>
    public sealed class FileWorkerSingleton
    {
        private static readonly Lazy<FileWorkerSingleton> instance =
            new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton("textSingleton.txt"));

        public static  FileWorkerSingleton Instance => instance.Value;
        
        /// <summary>
        /// Создание нового объекта для работы с текстом.
        /// </summary>
        private FileWorkerSingleton()
        {
            FilePath = "text.txt";
            ReadTextFromFile();
        }
        
        private FileWorkerSingleton(string path)
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