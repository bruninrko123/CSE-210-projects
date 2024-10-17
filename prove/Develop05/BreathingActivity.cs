using System.IO.Compression;

public class BreathingActivity : Activity
{


   

    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
        
    }
    public void Run()
    {   

        DisplayStartingMessage();
        


        //doing the breathings

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); 

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
           
            Console.Write("Now Breathe out...");
            ShowCountdown(5);
            Console.WriteLine("\n");
        }


        DisplayEndingMessage();
        
    }
}