using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        Running running = new Running(20.254, 57.8, "07 Jun 2024", "Running");
        _activities.Add(running);

        Swimming swimming = new Swimming(73, 10, "01 Aug 2024", "Swimming");
        _activities.Add(swimming);

        Cycling cycling = new Cycling(10.65, 30, "25 Dec 2021", "Cycling");
        _activities.Add(cycling);



        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.MakeSummary());
        }

    }
}