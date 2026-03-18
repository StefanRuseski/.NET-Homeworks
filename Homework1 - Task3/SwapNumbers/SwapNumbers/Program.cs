using System;

class Program
{
    static void Main()
    {
        // Input the first number
        Console.Write("Input the First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        // Input the second number
        Console.Write("Input the Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        // Swap the numbers
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        // Output the results after swapping
        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine($"First Number: {firstNumber}");
        Console.WriteLine($"Second Number: {secondNumber}");
    }
}

