using System.ComponentModel;

public class ChecklistGoal : Goal
{

    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

      public override bool IsComplete()
    {   
        if (_amountCompleted == _target)
        {
           return true; 
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string representation = $"Checklist goal:{_name},{_description},{_points},{_target},{_amountCompleted},{_bonus}";
        return representation;
    }

    public override string RecordEvent()
    {  
        bool test = IsComplete();
        if (test == false) 
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have earned {_points} points");

            if (_amountCompleted == _target)
            {
                IsComplete();
            }
            return _points;
        }

        else
        {
            Console.WriteLine("You are already done with this goal! you don't have to record it anymore.");
            return "0";
        }
    }

    public override string GetDetailsString()
    {
    string goalrepresentation = $"{_name},{_description},{_points},{IsComplete()},{_target},{_amountCompleted},{_bonus}";
    return goalrepresentation; 
    }

   
}