public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _UserList = new List<string>();

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
        string ThePrompt = GetRandomPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> Listings = new List<string>();
        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Listings = GetListFromUser();
            
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!\n");
        DisplayEndingMessage();
        SaveUserListIntoFile(Listings, ThePrompt);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);

        string prompt = _prompts[randomNumber];
        Console.WriteLine($"---{prompt}---");
        return prompt;
    }

    private List<string> GetListFromUser()
    {
        

        string response = Console.ReadLine();
        _UserList.Add(response);
        return _UserList;
    }

    private void SaveUserListIntoFile(List<string> ListFromTheUser, string prompt)
    {   
        int index = 0;
        using (StreamWriter writer = new StreamWriter("Listings.txt"))
        {   
            writer.WriteLine($"Prompt: {prompt}");
            writer.WriteLine();
            
            foreach (string item in ListFromTheUser)
            {   
                index++;

                writer.WriteLine($"{index}.{item}");
            }
        }
    }

    // private void SavePromptIntoFile(string prompt)
    // {
    //     using(StreamWriter writer = new StreamWriter("Listings.txt"))
    //     {
    //         writer.WriteLine($"Prompt: {prompt}");
    //         writer.WriteLine();
    //     }
    // }
}