namespace KataCocktails
{
    public abstract class FizzBuzzState
    {
        protected FizzBuzz context;

        public abstract string Get(int number);
        public void SetFizzBuzz(FizzBuzz fizzBuzz)
        {
            context = fizzBuzz;
        }

    }
}