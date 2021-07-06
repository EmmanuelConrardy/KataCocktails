using System;

namespace KataCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + " " + fizzbuzz.Get());
            }

            Console.ReadLine();
        }
    }
}
