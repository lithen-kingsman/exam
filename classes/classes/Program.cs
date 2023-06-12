using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        public class Person
        {
            public string Name;
            public string Surname;
            private int Age;

            public string GetInfo() => $"{Name} {Surname}, возраст {Age}";

            public void SetAge(int age)
            {
                if (age < 1 || age > 150)
                    throw new ArgumentException("Возраст должен быть от 1 до 150");
                Age = age;
            }
        }
    }
}
