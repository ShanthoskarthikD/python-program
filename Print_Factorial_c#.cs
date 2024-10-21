using System;

class FactorialProgram
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse32(Console.ReadLine());
        l factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial * = i;
        }
        Console.WriteLine("Factorial");
    }
}

