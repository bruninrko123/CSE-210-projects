public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;


    public Goal(string name, string desription, int points)
    {
        _name = name;
        _description = desription;
        _points = points;
    }
    public abstract bool IsComplete();
    
    public abstract void RecordEvent();

    public virtual string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public abstract string GetStringRepresentation();

    
}