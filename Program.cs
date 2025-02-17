using System;

// This class contains a method that performs math operations and displays values
public class MathOperations
{
    // This method takes two integers as parameters
    // It multiplies the first number by 2 and displays the second number
    public void ProcessNumbers(int firstNumber, int secondNumber)
    {
        int result = firstNumber * 2;
        Console.WriteLine($"First number multiplied by 2: {result}");
        Console.WriteLine($"Second number: {secondNumber}");
    }
}

class Program
{
    // Main method - entry point of the application
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method with positional parameters
        Console.WriteLine("Calling method with positional parameters:");
        mathOps.ProcessNumbers(5, 10);

        // Call the method with named parameters
        Console.WriteLine("\nCalling method with named parameters:");
        mathOps.ProcessNumbers(firstNumber: 7, secondNumber: 14);

        // Wait for user input before closing
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 