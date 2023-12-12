public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} kph, Pace: {CalculatePace()} min per km";
    }
}
