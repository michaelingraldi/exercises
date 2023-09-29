Random random = new Random();

//Sets up Array

int arraySize = 5;
int[] randomArray = new int[arraySize];

//Populates the array of numbers

for (int i = 0; i < arraySize; i++)
{
    int lowerLimit = i + 1;
    randomArray[i] = random.Next(lowerLimit,70);
}

//Displays the results

Console.WriteLine("Winning Numbers:");
foreach (int value in randomArray)
{
    Console.WriteLine(value);
}