public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>();


    public ListingActivity()
    {
       _name = "Listing Activity";
       _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


       _prompts.Add("Who are people that you appreciate?");
       _prompts.Add("What are personal strengths of yours?  ");
       _prompts.Add("Who are people that you have helped this week?");
       _prompts.Add("When have you felt the Holy Ghost this month?");
       _prompts.Add("Who are some of your personal heroes?");

    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int counter = 0;
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!\n");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);

        string prompt = _prompts[randomNumber];
        Console.WriteLine($"---{prompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> UserList = new List<string>();
        return UserList;
    }
}