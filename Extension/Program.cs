using System;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string ToCurrency(this string input)
    {
        // Use regular expression to check if the string contains numbers
        if (Regex.IsMatch(input, @"\d"))
        {
            // String contains numbers, prepend "$" sign and return the new string
            return "$" + input;
        }
        else
        {
            // String does not contain numbers, throw an exception
            //throw new ArgumentException("The input string does not contain numbers.");
            return "Does not have numbers!";

        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            string result = userInput.ToCurrency();
            Console.WriteLine("Formatted string: " + result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
