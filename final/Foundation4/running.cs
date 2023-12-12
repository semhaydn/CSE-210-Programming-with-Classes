public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _length * 60;
    }

    public override double CalculatePace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {_distance} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}