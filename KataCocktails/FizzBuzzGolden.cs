namespace KataCocktails
{
    public class FizzBuzzGolden : FizzBuzz
    {
        public FizzBuzzGolden() : base()
        {
        }

        public override string GetGolden()
        {
            return currrentState.Get(++currentNumber);
        }
    }
}