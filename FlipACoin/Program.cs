using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlipACoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int flip;
            //Prompt for input
            Console.Write("Will it be Heads or Tails? (H or T)");
            //Read in guess
            guess = Console.ReadLine();
            //Flip the coin
            Random rng = new Random();
            flip = rng.Next(0,2);
            //Determine results
            if (flip == 0 && guess == "H" || flip == 1 && guess == "T")
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("Sorry, that's incorrect");
            }
            Console.ReadLine();
        }
    }
}