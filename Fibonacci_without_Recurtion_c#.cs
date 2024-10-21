using System;

class FibonacciWithoutRecursion
{
    static void Main()
    {
        int n = 15;                                // No of terms to print
        int a = 0, b = 1, next;

        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
    }
}
