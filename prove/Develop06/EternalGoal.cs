
using System.Diagnostics.Metrics;

public class EternalGoal : Goal
{
    
private DateTime _lastTime;
private int _Counter;

public EternalGoal(string name, string description, string points, int counter, DateTime lastTime) : base(name, description, points)
{
    _lastTime = lastTime;
    _Counter = counter;
}

      public override bool IsComplete()
    {
        return false;
    }


   

    public override string RecordEvent()
    {   

        _Counter++;

        if (_Counter > 1)
        {
        DateTime timeNow = DateTime.Now;
        TimeSpan elapsedTime = timeNow - _lastTime;




        if ( elapsedTime.TotalHours < 48)
        {
        Console.WriteLine($"Congratulations! You have earned {_points} points");
        _lastTime = DateTime.Now;
        }

        else 
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points");
            Console.WriteLine("But be careful, you took more than 48 hours to do your eternal goal");
            _lastTime = DateTime.Now;
        }
        }

        else if (_Counter <= 1)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points");
        _lastTime = DateTime.Now;
        }

        return _points;


        

    }

     public override string GetStringRepresentation()
    {   
        string representation = $"Eternal goal|{_name}|{_description}|{_points}|{_Counter}|{_lastTime}";
        return representation;
        
    }
}