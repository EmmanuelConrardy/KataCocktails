namespace KataCocktails
{
    public class StateNumber : FizzBuzzState
    {
        public override string Get(int number)
        {
            int n = number + 1;

            if (n % 15 == 0)
                context.TransitionTo(new StateFizzBuzz());
            else if (n % 5 == 0)
                context.TransitionTo(new StateBuzz());
            else if (n % 3 == 0)
                context.TransitionTo(new StateFizz());

            return number.ToString();
        }


    }
    public class StateBuzz : FizzBuzzState
    {
        public override string Get(int number)
        {
            int n = number + 1;

            if (n % 3 == 0)
                context.TransitionTo(new StateFizz());
            else
                context.TransitionTo(new StateNumber());

            return "Buzz";
        }
    }

    public class StateFizzBuzz : FizzBuzzState
    {
        public override string Get(int number)
        {
            context.TransitionTo(new StateNumber());

            return "FizzBuzz";
        }
    }

    public class StateFizz : FizzBuzzState
    {
        public override string Get(int number)
        {
            int n = number + 1;

            if (n % 5 == 0)
                context.TransitionTo(new StateBuzz());
            else
                context.TransitionTo(new StateNumber());

            return "Fizz";
        }
    }
}