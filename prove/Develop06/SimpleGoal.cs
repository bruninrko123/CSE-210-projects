public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        
        return _isComplete;
    }


    public override string RecordEvent()
    {
        if (_isComplete == false)
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points");
            _isComplete = true;
            return _points;
        }
        
        else 
        {
            Console.WriteLine("This is a simple, one time goal and you have already recorded it.");
            return "0";
        }
        
        
    }

    public override string GetStringRepresentation()
    {   
        string representation = $"Simple goal|{_name}|{_description}|{_points}|{_isComplete}";
        return representation;
    }



}