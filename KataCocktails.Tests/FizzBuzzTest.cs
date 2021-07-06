using System;
using System.Text;
using Xunit;

namespace KataCocktails.Tests
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();


        [Fact]
        public void Display_number_2()
        {
            Assert.Equal("1", fizzBuzz.Get());
            Assert.Equal("2", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("4", fizzBuzz.Get());
            Assert.Equal("Buzz", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("7", fizzBuzz.Get());
            Assert.Equal("8", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("Buzz", fizzBuzz.Get());
            Assert.Equal("11", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("13", fizzBuzz.Get());
            Assert.Equal("14", fizzBuzz.Get());
            Assert.Equal("FizzBuzz", fizzBuzz.Get());
            Assert.Equal("16", fizzBuzz.Get());
            Assert.Equal("17", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("19", fizzBuzz.Get());
            Assert.Equal("Buzz", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("22", fizzBuzz.Get());
            Assert.Equal("23", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("Buzz", fizzBuzz.Get());
            Assert.Equal("26", fizzBuzz.Get());
            Assert.Equal("Fizz", fizzBuzz.Get());
            Assert.Equal("28", fizzBuzz.Get());
            Assert.Equal("29", fizzBuzz.Get());
            Assert.Equal("FizzBuzz", fizzBuzz.Get());
        }

        [Fact]
        public void Test_golden()
        {
            var fizzbuzz = new FizzBuzz();

            var stringbuilder = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                stringbuilder.AppendLine(i + " " + fizzbuzz.Get());
            }

            var fizzbuzzGolden = new FizzBuzzGolden();

            var stringbuilder2 = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                stringbuilder2.AppendLine(i + " " + fizzbuzzGolden.Get());
            }

            Assert.Equal(stringbuilder.ToString(), stringbuilder2.ToString());
        }
    }
}
