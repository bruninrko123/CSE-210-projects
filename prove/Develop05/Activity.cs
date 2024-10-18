using System.Diagnostics;
using System.Diagnostics.Metrics;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0; 

    


    public Activity()
    {
        
    }

    

    public void DisplayStartingMessage()
    {   
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string seconds = Console.ReadLine();
        int duration = int.Parse(seconds);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\n");

        _duration = duration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.Clear();
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> _symbols = new List<string>();
        _symbols.Add("-");
        _symbols.Add("\\");
        _symbols.Add("|");
        _symbols.Add("/");
        _symbols.Add("-");
        _symbols.Add("\\");
        _symbols.Add("|");
        _symbols.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int Counter = 0;
        while(DateTime.Now < endTime)
        {   
            
            Console.Write(_symbols[Counter]);
            Thread.Sleep(600);
            Console.Write("\b \b");

            Counter ++;
            
            if (Counter >= 8)
            {
                Counter = 0;
            } 

        }
    }

    public void ShowCountdown(int seconds)
    {
        
        

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}