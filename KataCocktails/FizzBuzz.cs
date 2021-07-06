using System;

namespace KataCocktails
{
    public class FizzBuzz
    {
        protected FizzBuzzState currrentState = null;
        protected int currentNumber;

        public FizzBuzz()
        {
            currrentState = new StateNumber();
            currrentState.SetFizzBuzz(this);
            currrentState.Get(currentNumber);
        }

        public string Get()
        {
            string result = GetGolden();
            return result;
        }

        public virtual string GetGolden()
        {
            return currrentState.Get(++currentNumber);
        }

        public void TransitionTo(FizzBuzzState state)
        {
            this.currrentState = state;
            this.currrentState.SetFizzBuzz(this);
        }
    }
}