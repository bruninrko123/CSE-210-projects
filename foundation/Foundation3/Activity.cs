public abstract class Activity
{
    private double _Lenght;
    private DateTime _date;

    private string _activityName;


    public Activity(double lenght, string date, string activityName)
    {
        _Lenght = lenght;
        _date = DateTime.Parse(date);
        _activityName = activityName;
    }
    public abstract double CalculateDistance();
    

    public abstract double CalculateSpeed();
    

    public virtual double CalculatePace()
    {
        return GetLength() / (CalculateDistance());
    }

    public virtual string MakeSummary()
    {
        string  date = GetDate().ToString("dd MMM yyyy");

        return $"{date} {_activityName} ({GetLength()} min) - Distance: {CalculateDistance().ToString("0.00")} km, Speed: {CalculateSpeed().ToString("0.00")} kph, Pace: {CalculatePace().ToString("0.00")} min per km";
    
    }

    public double GetLength()
    {
        return _Lenght;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}