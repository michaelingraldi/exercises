namespace HelloName.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace HelloName
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Greetings, weary traveler. What is your name? ");
                String name = Console.ReadLine();
                Console.WriteLine("Welcome to NewHaven, " + name);
            }
        }
    }
}