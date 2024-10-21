using System;
class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse32(Console.ReadLine());
        
        if (IsPalindrome(number))
        {
            Console.WriteLine(number + " is a palindrome.");
        }
        else
        {
            Console.WriteLine(number + " is not a palindrome.");
        }
    }
    static bool IsPalindrome  (int num)
    {
        int orgNum = num;
        int revNum = 0;

        while (num > 0)
        {
            int digit = num % 10; 
            revNum = revNum * 10 + digit;                               // rev num
            num /= 10; 
        }
        return orgNum == revNum;                                       // Check if org and rev are the same
    }
}
