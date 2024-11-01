using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("27 Oct 2024", 30, 4.8),
            new Cycling("28 Oct 2024", 45, 25),
            new Swimming("29 Oct 2024", 20, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
