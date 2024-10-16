
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {   
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }
    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"{number} is negative");
        }else
            {
                if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }else
                {
                    Console.WriteLine($"{number} is zero");      
                }
            }
    }
    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine($"The minimum value between {num1}, {num2}, and {num3} is {num1}");
        }else
            {
                if (num2 < num3)
                {
                    Console.WriteLine($"The minimum value between {num1}, {num2}, and {num3} is {num2}");
                }else
                    {
                        Console.WriteLine($"The minimum value between {num1}, {num2}, and {num3} is {num3}");
                    }
            }
    }
    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"The maximum value between {num1}, {num2}, and {num3} is {num1}");
        }else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"The maximum value between {num1}, {num2}, and {num3} is {num2}");
                }else
                    {
                        Console.WriteLine($"The maximum value between {num1}, {num2}, and {num3} is {num3}");
                    }
            }
    }
    public static void IsDivisibleBy5(int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine($"{number} is divisble by 5");
        }else
            {
                Console.WriteLine($"{number} is not divisble by 5");
            }
    }
    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 1)
        {
            Console.WriteLine($"{number} is Odd");
        }else
            {
                Console.WriteLine($"{number} is Even");
            }
    }
    public static void CheckVowelOrConsonant(char letter)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
        {
            Console.WriteLine($"{letter} is a vowel");
        }else
            {
                Console.WriteLine($"{letter} is a consonant");
            }
    }
    public static void DisplayDayOfWeek(int dayCode)
    {
        switch(dayCode)
        {
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
	        Console.WriteLine("Monday");
            break;
            case 2:
	        Console.WriteLine("Tuesday");
            break;
            case 3:
	        Console.WriteLine("Wednesday");
            break;
            case 4:
	        Console.WriteLine("Thursday");
            break;
            case 5:
	        Console.WriteLine("Friday");
            break;
            case 6:
	        Console.WriteLine("Saturday");
            break;
        }
    }
}

