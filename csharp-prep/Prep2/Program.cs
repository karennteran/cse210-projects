using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        string letter = "";

        if (percentage >= 90 || percentage >= 97 )
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }


        if (percentage >= 70)
        {
            Console.WriteLine("congratulations you've passed");
        } 
        else
        {
            Console.WriteLine("You Failed, Try again and study more");
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}