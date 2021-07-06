using System;
using System.Text;

namespace KataCocktails
{
    /// <summary>
    /// By Sylvain Kocher & Emmanuel Conrardy
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzz = new FizzBuzz();

            var stringbuilder = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                stringbuilder.AppendLine(i + " " + fizzbuzz.Get());
            }
            Console.WriteLine("FizzBuzz");
            Console.WriteLine(stringbuilder.ToString());

            var fizzbuzzGolden = new FizzBuzzGolden();

            var stringbuilder2 = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                stringbuilder2.AppendLine(i + " " + fizzbuzzGolden.Get());
            }

            Console.WriteLine("FizzBuzzGolden");
            Console.WriteLine(stringbuilder2.ToString());
            Console.ReadLine();
        }
    }
}
