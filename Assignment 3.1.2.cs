/* Assignment 3.1.2
2. If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false

research how to check if a year is leap, use algorithm
*/

public class Program
{
    public static void Main(string[] args)
    {
        // test cases
        Console.WriteLine("2016 is a leap year: " + IsYearLeap(2016)); // true
        Console.WriteLine("2018 is a leap year: " + IsYearLeap(2018)); // false
        Console.WriteLine("1900 is a leap year: " + IsYearLeap(1900)); // false
        Console.WriteLine("2000 is a leap year: " + IsYearLeap(2000)); // true
        Console.WriteLine("2024 is a leap year: " + IsYearLeap(2024)); // true
        Console.WriteLine("2100 is a leap year: " + IsYearLeap(2100)); // false
        // user input
        Console.WriteLine("Enter a year to check if it is a leap year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(year + " is a leap year: " + IsYearLeap(year));
    }

public static bool IsYearLeap(int year) // if it is divisible by 4 but not by 100, except if it is divisible by 400.
    {
        bool isLeap = false;
        if (year % 4 == 0 &&  year % 100 != 0 || year % 400 == 0)
        {
            isLeap = true;
        }
        else
        {
            isLeap = false;
        }
        return isLeap;
    }
} 