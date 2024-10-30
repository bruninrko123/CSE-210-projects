using System.Security.Cryptography.X509Certificates;

public class Swimming : Activity
{
    int _laps;


    public Swimming(int laps, int length, string date, string activityName) : base(length,date, activityName)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 0.05;
    }

   

    public override double CalculateSpeed()
    {
        return CalculateDistance() / (GetLength() / 60);
    }
}