using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new NumberGenerator());
            game.Start();

            Console.WriteLine("Guessing game");
            Result result = Result.TooLow;
            do
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                string userInput = Console.ReadLine();
                int guessValue;

                if (int.TryParse(userInput, out guessValue))
                {
                    result = game.Guess(guessValue);

                    switch (result)
                    {
                        case Result.TooHigh:
                            Console.WriteLine("Too high, try again.");
                            break;
                        case Result.TooLow:
                            Console.WriteLine("Too Low, try again.");
                            break;
                        case Result.Correct:
                            Console.WriteLine("Correct!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid number format");
                }
            } while (result != Result.Correct);

            Console.WriteLine("You required {0} attempts.", game.Attempts);
            Console.ReadLine();
        }
    }
}
