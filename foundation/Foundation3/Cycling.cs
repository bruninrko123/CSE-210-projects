public class Cycling : Activity
{
    double _speed;


    public Cycling(double Speed, double length, string date, string activityName) : base(length,date, activityName)
    {
        _speed = Speed;
    }

    public override double CalculateDistance()
    {   
        double comp = GetLength();
        double lenghtHours = comp / 60;
        return _speed * lenghtHours;
    }

 

    public override double CalculateSpeed()
    {
        return _speed;
    }


}