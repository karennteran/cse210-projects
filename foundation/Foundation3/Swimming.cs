public class Swimming : Activity
{
    private int laps;
    private const double LapDistance = 50 / 1000.0; // in kilometers

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * LapDistance;
    public override double GetSpeed() => (GetDistance() / Duration) * 60;
    public override double GetPace() => Duration / GetDistance();
}
