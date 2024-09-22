using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = 0;


        while (guess != number)
        {
            Console.WriteLine("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
        

            if (number < guess)
            {
                Console.WriteLine("Lower");
            }

            else if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it, congratulations");
            }
        }
    }
}