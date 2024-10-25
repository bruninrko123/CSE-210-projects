public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;


    public Goal(string name, string desription, string points)
    {
        _name = name;
        _description = desription;
        _points = points;
    }
    public abstract bool IsComplete();
    
    public abstract string RecordEvent();

    public virtual string GetDetailsString()
    {   
       string goalrepresentation = $"{_name},{_description},{_points},{IsComplete()}";
        return goalrepresentation;
    }

    public abstract string GetStringRepresentation();

    
}