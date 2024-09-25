//create resume class

public class Resume
{   

    public Resume()
    {

    }
    public string _name;
    public List<Job> _JobsList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job j in _JobsList)
        {
            j.DisplayCompanyInfo();
        }
    }
}