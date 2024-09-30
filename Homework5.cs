namespace Homework5;

using System;

class Program
{
    //Q1_method
    static int GetMax2(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //Q2_method
    
    static int GetMax4(int a, int b, int c, int d)
    {
        int max1 = GetMax2(a, b);
        int max2 = GetMax2(c, d);
        return GetMax2(max1, max2);
    }
    //Q3_Method
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }
    static void createAccount()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your password: ");
        string   
 password = Console.ReadLine();

        Console.Write("Enter your password again: ");
        string confirmPassword = Console.ReadLine();

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully!");
            }
            else
            {
                Console.WriteLine("Passwords do not match.");
            }
        }
        else
        {
            Console.WriteLine("You must be at least 18 years old to create an account.");
        }
    }
    static void Main()
    {
        //Call Q1_Method()
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine()); 


        int max = GetMax2(num1, num2);
        Console.WriteLine("The largest number is: " + max);
        //Call Q2_Method()
        Console.Write("Enter the first integer: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int num4 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third integer: ");
        int num5 = int.Parse(Console.ReadLine());   

        Console.Write("Enter the fourth integer: ");
        int num6 = int.Parse(Console.ReadLine());

        int max2 = GetMax4(num3, num4, num5, num6);
        Console.WriteLine("The largest number is: " + max2);
        //Call Q3_method()
        createAccount();

    }
    
}
