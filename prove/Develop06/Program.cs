using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal(goalManager);
                    break;
                case 2:
                    goalManager.ListGoalDetails();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    RecordEvent(goalManager);
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        int target = 0;
        int bonus = 0;
        if (goalType == 3) // Checklist Goal
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
        }

        goalManager.CreateGoal(goalType, name, description, points, target, bonus);
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Select a goal to record:");
        goalManager.ListGoalDetails();
        Console.Write("Enter the goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        goalManager.RecordEvent(goalIndex);
        Console.WriteLine("Event recorded successfully!");
    }
}
