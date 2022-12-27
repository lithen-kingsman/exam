using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace task06_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("кинематограф");

            string word = "кинематограф";
            string grafoman = word.Substring(8) + word[7].ToString() + word.Substring(4, word.Length - 10) + word[2].ToString();
            string metro = word[4].ToString() + word[3].ToString() + word[6].ToString() + word[9].ToString() + word[7].ToString();

            Console.WriteLine(grafoman);
            Console.WriteLine(metro);
            Console.ReadKey();

     }  }  
}
