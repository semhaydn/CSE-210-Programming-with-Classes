public class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double CalculateDistance()
    {
        return 0.0;
    }

    public virtual double CalculateSpeed()
    {
        return 0.0;
    }

    public virtual double CalculatePace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"Summary: {_date} {_length} min";
    }
}
