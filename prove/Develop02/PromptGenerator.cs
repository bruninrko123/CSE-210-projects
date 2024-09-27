using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"what name?", "What age?", "what color?", "what'sup?", "how far?"};

    //public void FillList()
    //{
        //_prompts.Add("What was your favorite part of the day?");
        //_prompts.Add("What is your name?");
       // _prompts.Add("What's up?");
        //_prompts.Add("where are you?");
    //}
   


    public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int randomNumber = random.Next(0,4);
        
        Console.WriteLine($"{_prompts[randomNumber]}");
        
       
        return _prompts[randomNumber];
    }
}