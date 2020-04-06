using System;
using System.Net.Http.Headers;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Matthew", lastName = "Shorter", major = "Unknown";

            int a = 12, b = 20;

            string sumString = "The Sum is ";

            int num1 = 478, num2 = 984, num3 = 145;

            float piFloat = 355f / 113f;

            Console.WriteLine($"Hello, {firstName}!");
            Console.WriteLine($"{firstName} {lastName}'s major is {major}");
            Console.WriteLine(a + b);
            Console.WriteLine(sumString + a + b); // Adding to a string in C# is an append-like operation
            Console.WriteLine("The average of " + num1 + ", " + num2 + ", and " + num3 + " is equal to " + ((num1 + num2 + num3)/3)+".");
            Console.WriteLine("Float: " + piFloat);
        }
    }
}
