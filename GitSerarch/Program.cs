using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define the root directory where you want to start the search.
        string rootDirectory = @"C:\Users\11600K";

        // Define the directory to exclude from the search.
        string excludedDirectory = @"C:\Users\11600K\AppData";

        // Define a regular expression pattern for six numerical digits.
        Regex pattern = new Regex(@"\d{6}");

        // Start the search by calling a recursive method.
        SearchForNumericalDigits(rootDirectory, excludedDirectory, pattern);
    }

    static void SearchForNumericalDigits(string directory, string excludedDirectory, Regex pattern)
    {
        try
        {
            // Check if the current directory is the excluded directory.
            if (string.Equals(directory, excludedDirectory, StringComparison.OrdinalIgnoreCase))
            {
                return; // Skip processing this directory.
            }

            // Get all files in the current directory with a .txt extension.
            string[] txtFiles = Directory.GetFiles(directory, "*.txt");

            foreach (string txtFile in txtFiles)
            {
                // Read the contents of the .txt file.
                string fileContents = File.ReadAllText(txtFile);

                // Check if the file contents contain the pattern.
                if (pattern.IsMatch(fileContents))
                {
                    // If a match is found, print the file path.
                    Console.WriteLine("Match found in file: " + txtFile);
                }
            }

            // Recursively search subdirectories.
            string[] subdirectories = Directory.GetDirectories(directory);
            foreach (string subdirectory in subdirectories)
            {
                SearchForNumericalDigits(subdirectory, excludedDirectory, pattern);
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur while accessing files or directories.
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
