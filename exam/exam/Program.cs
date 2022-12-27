using System;

namespace exam
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());


            IsPrime(number);
            int a;
            string multiply = $"Разложение числа {number} =";

            for (a = 2; number > 1; a++)
            {
                if (IsPrime(a))
                {
                    if (number % a == 0)
                    {
                        int x = 0;
                        while (number % a == 0)
                        {
                            number /= a;
                            x++;
                        }
                        multiply += $" {a}^{x} *";
                    }
                }
            }

            Console.WriteLine($" {multiply}".Remove(multiply.Length));
            Console.ReadKey();
        }
        static bool IsPrime(int number)
        {
            bool a = false;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                a = true;
            }
            return a;
        }
    }
}




      
