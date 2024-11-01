using System;

public abstract class Activity
{
    private string date;
    private int duration; // in minutes

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public int Duration => duration;

    public virtual double GetDistance() => 0; // To be overridden in derived classes
    public virtual double GetSpeed() => 0;    // To be overridden in derived classes
    public virtual double GetPace() => 0;     // To be overridden in derived classes

    public virtual string GetSummary()
    {
        return $"{date} ({duration} min): Distance {GetDistance():F1} km, " +
               $"Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
