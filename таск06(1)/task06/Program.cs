using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке:");
            string rustext = Console.ReadLine();    

            Console.WriteLine("Транслитерация с русского на английский: " + TransliterationRusToEng(rustext));
            Console.ReadKey();
            }
        public static string TransliterationRusToEng (string rustext)
        {
            return rustext.Replace("а", "a").Replace("А", "A").Replace("б", "b").Replace("Б", "B").Replace("в", "v").Replace("В", "V").Replace("г", "g").Replace("Г", "G").Replace("д", "d").Replace("Д", "D").Replace("е", "e").Replace("Е", "E").Replace("ё", "e").Replace("Ё","E").Replace("ж", "zh").Replace("Ж", "ZH").Replace("з", "z").Replace("З","Z").Replace("и", "i").Replace("И","I").Replace("й", "i").Replace("Й","I").Replace("к", "k").Replace("К","K").Replace("л", "l").Replace("Л","L").Replace("м", "m").Replace("М","M").Replace("н", "n").Replace("Н","N").Replace("О","O").Replace("о", "o").Replace("п", "p").Replace("П","P").Replace("р", "r").Replace("Р","R").Replace("с", "s").Replace("С","S").Replace("т", "t").Replace("Т","T").Replace("у", "u").Replace("У","U").Replace("ф", "f").Replace("Ф","F").Replace("х", "kh").Replace("Х","KH").Replace("ц", "ts").Replace("Ц","TS").Replace("ч", "ch").Replace("Ч","CH").Replace("ш", "sh").Replace("Ш", "SH").Replace("щ", "shch").Replace("Щ", "SHCH").Replace("ъ", "ie").Replace("Ъ", "IE").Replace("ы", "y").Replace("Ы", "Y").Replace("ь", "").Replace("Ь", "").Replace("э", "e").Replace("Э", "E").Replace("ю", "iu").Replace("Ю", "IU ")
                .Replace("я", "ia").Replace("Я", "IA");
        }
    }
    
}
    
