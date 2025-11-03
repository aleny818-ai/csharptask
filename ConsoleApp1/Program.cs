using System;

class Task2
{
    static void Main()
    {
        // Step 2: Declare and initialize the 2D array
        int[,] numberMatrix = new int[2, 5]  // 2 rows, 5 columns
        {
            { 2, 4, 6, 8, 10 },  // Row 0: Even numbers
            { 1, 3, 5, 7, 9 }    // Row 1: Odd numbers
        };

        Console.WriteLine("The number matrix has been initialized.");

        // Step 3: Extract specific digits based on the puzzle clues
        int digit1 = numberMatrix[1, 3];  // Row 1, Index 3 -> 7
        int digit2 = numberMatrix[0, 0];  // Row 0, Index 0 -> 2
        int digit3 = numberMatrix[1, 4];  // Row 1, Index 4 -> 9

        // Combine the digits into a 3-digit key
        string password = $"{digit1}{digit2}{digit3}";  // Combining digits into a string

        // Output the result
        Console.WriteLine("The 3-digit password is: " + password);
    }
}
