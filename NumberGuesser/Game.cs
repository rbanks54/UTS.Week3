using System;

namespace NumberGuesser
{
    public class Game
    {
        private INumberGenerator random;

        public Game(INumberGenerator numberGenerator)
        {
            this.random = numberGenerator;
        }

        public int Number { get; set; }
        public int Attempts { get; private set; }

        public void Start() { Number = random.Next(); }

        public Result Guess(int guess)
        {
            Attempts++;
            if (guess < Number)
                return Result.TooLow;
            else if (guess > Number)
                return Result.TooHigh;
            else
                return Result.Correct;
        }
    }
}
