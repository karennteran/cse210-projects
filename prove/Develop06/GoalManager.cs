using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal(int goalType, string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal newGoal;
        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                throw new ArgumentException("Invalid goal type");
        }
        _goals.Add(newGoal);
    }

    public void SaveGoals()
    {
        // Implement Save functionality here
    }

    public void LoadGoals()
    {
        // Implement Load functionality here
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.Points;  // Assuming `Points` is a property of `Goal`
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}
