
public class EternalGoal : Goal
{
    



public EternalGoal(string name, string description, string points) : base(name, description, points)
{
    
}

      public override bool IsComplete()
    {
        return false;
    }


   

    public override string RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points");
        return _points;
        
    }

     public override string GetStringRepresentation()
    {   
        string representation = $"Eternal goal:{_name},{_description},{_points}";
        return representation;
        
    }
}