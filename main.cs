// Created by: sophie
// Created on: dec 2020
//
// This program does loops and math

using System;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        int num1;
        int num2;
        int sum = 1;

        Console.WriteLine("this program calculates exponents with a while loop");

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("to the power of: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while (count < num2)
        {
            sum *= num1;
            count++;
        }
        Console.WriteLine("your answer is: " + sum + ".");
        Console.WriteLine("\nDone.");
    }
}