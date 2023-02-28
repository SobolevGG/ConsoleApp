using System;
using Model;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Ilya",
                Surname = "Sobolev",
                Age = 24
            };

            Console.ReadKey();
        }
    }
}