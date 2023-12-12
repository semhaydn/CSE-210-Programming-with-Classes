public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }

    public override double CalculatePace()
    {
        return _length / CalculateDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}
