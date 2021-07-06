using System;
using Xunit;

namespace KataCocktails.Tests
{
    public class FizzBuzzTest
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();
        
        [Fact]
        public void Display_number_1()
        {
            Assert.Equal("1", fizzBuzz.Get(1));
        }

        [Fact]
        public void Display_number_2()
        {
            Assert.Equal("2", fizzBuzz.Get(2));
        }

        [Fact]
        public void Display_number_3()
        {
            Assert.Equal("Fizz", fizzBuzz.Get(3));
        }

        [Fact]
        public void Display_number_4()
        {
            Assert.Equal("4", fizzBuzz.Get(4));
        }

        [Fact]
        public void Display_number_5()
        {
            Assert.Equal("Buzz", fizzBuzz.Get(5));
        }

        [Fact]
        public void Display_number_6()
        {
            Assert.Equal("Fizz", fizzBuzz.Get(6));
        }

        [Fact]
        public void Display_number_7()
        {
            Assert.Equal("7", fizzBuzz.Get(7));
        }

        [Fact]
        public void Display_number_10()
        {
            Assert.Equal("Buzz", fizzBuzz.Get(10));
        }

        [Fact]
        public void Display_number_15()
        {
            Assert.Equal("FizzBuzz", fizzBuzz.Get(15));
        }

        [Fact]
        public void Display_number_30()
        {
            Assert.Equal("FizzBuzz", fizzBuzz.Get(30));
        }
    }
}
