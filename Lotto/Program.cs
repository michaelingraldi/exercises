Random random = new Random();


//Sets up Arrays
//Player Guesses

int arraySize = 5;
int[] guessArray = new int[arraySize];

//Results
int[] resultsArray = new int[arraySize];

//Collect player input
Console.WriteLine("Let's Play The Lottery!");
Console.WriteLine("Time to pick your numbers.");


for (int i = 0; i < guessArray.Length; i++)
{
    Console.Write("Enter a number between 1 and 70, then press Enter");
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input); // Parse the input and store it in a variable
    guessArray[i] = parsedInput; // Store the parsed integer in the guessArray
}


//Populates the array of numbers

for (int i = 0; i < arraySize; i++)
{
    int lowerLimit = i + 1;
    resultsArray[i] = random.Next(lowerLimit,70);
}

//Displays the results
Console.WriteLine("Your Numbers: ");
foreach (int value in guessArray)
{
    Console.WriteLine(value);
}
Console.WriteLine("Winning Numbers:");
foreach (int value in resultsArray)
{
    Console.WriteLine(value);
}
Console.ReadLine();