using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"what was the favorite part of your day?", "did you eat anything special today?", "Who was the dearest person you met today?", "If you could change anything in you day what would it be?", "did anything stress you today?","How did you see the Lord's hand in your day?"};

   
   


    public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int randomNumber = random.Next(0,4);
        
        Console.WriteLine($"{_prompts[randomNumber]}");
        
       
        return _prompts[randomNumber];
    }
}