using System.Security.Cryptography;

namespace HighLowGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int guess;
            int count = 0;
            string input;
            bool correctGuess = false;
            //Generate the number
            Random rng = new Random();
            number = rng.Next(0, 101);
            
            
            Console.WriteLine("Welcome to the High/Low Game!");
            //Play the game
            while(correctGuess == false)
            {
                Console.WriteLine("Please guess a number between 1 and 100");
                input = Console.ReadLine();
                guess = int.Parse(input);
                if(guess > number)
                {
                    Console.WriteLine("Too high! Please Try Again");
                    count++;
                }
                else if(guess < number)
                {
                    Console.WriteLine("Too low! Please Try Again");
                    count++;
                }
                else
                {
                    correctGuess = true;
                    count++;
                }
            }
            //Close out game
            Console.WriteLine("Yes! The number was {0}. Congratulations!", number);
            Console.WriteLine("It took {0} guesses.",count);


            
            guess = Console.Read();


        }
    }
}