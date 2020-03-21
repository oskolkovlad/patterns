using System;
using System.Threading;

// Классическая потокобезопасная реализация Singleton
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker fileWorker1 = new FileWorker();
            FileWorker fileWorker2 = new FileWorker();
            fileWorker1.WriteText("Hello!");
            fileWorker2.WriteText("My name is Vlad!");
            fileWorker1.Save();
            fileWorker2.Save();
            
            
            //*********************************************************//

            
            var singleton1 = FileWorkerSingleton.Instance;
            var singleton2 = FileWorkerSingleton.Instance;
            singleton1.WriteText("Hello! ");
            singleton2.WriteText("My name is Vlad!");
            singleton1.Save();
            singleton2.Save();
            
            
            //*********************************************************//


            new Thread(() =>
            {
                Computer comp2 = new Computer();
                comp2.OS = OS.getInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);
 
            })).Start();
 
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);
            Console.ReadLine();
            
            
            //*********************************************************//
            
            
            Console.ReadKey();
        }
    }
}