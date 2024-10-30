public class Running : Activity
{
    double _distance;



    public Running(double distance, double length, string date, string activityName) : base(length, date, activityName)
    {
        _distance = distance;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {   
        double length = GetLength();
        double lengthHours = length / 60;
        
        return _distance / lengthHours;
    }

    public override double CalculatePace()
    {
        return GetLength() / (_distance);
    }

    

}