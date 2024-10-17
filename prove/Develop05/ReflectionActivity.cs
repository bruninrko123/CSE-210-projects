public class ReflectionAcitivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectionAcitivity()
    {
        _name = "Reflecting activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        
    }


    public void Run()
    {
        DisplayStartingMessage();
        


        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue\n");
        string ready = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {   
            GenerateRandomQuestions();
            DisplayQuestions();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {   
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);

        string prompt = _prompts[randomNumber];
        return prompt;
    }

    
    public void DisplayPrompt()
    {
        
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($">{GenerateRandomQuestions()}");
    }

    public string GenerateRandomQuestions()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count - 1);

        string prompt = _questions[randomNumber];
        return prompt;
    }
}