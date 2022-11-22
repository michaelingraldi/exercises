namespace SimpleAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int num1 = int.Parse(input);
            Console.Write("Please enter your second number: ");
            input = Console.ReadLine();
            int num2 = int.Parse(input);
            int sum = num1 + num2;
            Console.WriteLine("The sum of your numbers is: " + sum);
            Console.ReadLine();

        }
    }
}