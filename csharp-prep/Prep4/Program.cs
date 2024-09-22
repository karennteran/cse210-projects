using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a series of numbers, type 0 when finished.");
        
        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number == 0)

            {
                Console.WriteLine("You finished!!");
                break;
            }

            numbers.Add(number);

        }
    }
}