using System;
using System.IO;

namespace filesanddirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("text.txt"))
               File.Create("text.txt").Close();

          if (!File.Exists("copy.txt"))
            File.Copy("text.txt", "copy.txt");

            //File.Delete("text.txt");

            var myFile = new FileInfo("copy.txt");
            myFile.Delete();

            var s = File.ReadAllText("text.txt");
            Console.WriteLine(s);

            File.WriteAllText("text.txt", "аа все стерлось или нет?");

            Console.WriteLine(s);
            File.WriteAllLines("text.txt",
                new string[]
                {
                    "Первая строка",
                    "Вторая строка"
                });
            Console.WriteLine();

            using(var f = new StreamReader("text.txt"))
            {
                while(f.EndOfStream)
                {
                    var line = f.ReadLine().ToLower();
                    Console.WriteLine(line);
                }
            }

            //var lines = File.ReadAllLines("text.txt");
            //foreach (var line in lines)
            //    Console.WriteLine(line);

            //var bytes = File.ReadAllBytes("text.txt");
            //foreach (var b in bytes)
            //    Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
