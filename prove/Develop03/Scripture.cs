public class Scripture
{
    private List<string> _showScripture = new List<string>();

    public Scripture()
    {
        string defaultScripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        string[] words = defaultScripture.Split(" ");

        foreach (string w in words)
        {
            _showScripture.Add(w);
        }
        
    }


    public void displayScripture()
    {   
        Console.Clear();
        foreach (string w in _showScripture)
        {
            Console.Write(w + " ");
            
        }
        Console.WriteLine();
    }


    public void Hide()
    {   
        string decision = "";
        int lenghtList = _showScripture.Count;
        do{
        Console.WriteLine("Press enter to continue or type 'quit' to finish ");
        decision = Console.ReadLine();
         
        ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {   
                for (int g = 0; g < 3; g++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, lenghtList - 1);

                    string inputString = _showScripture[randomNumber];
                    int lenghtCharacter = inputString.Length;
                    _showScripture[randomNumber] = "";

                    for (int i = 0; i < lenghtCharacter; i++)
                    {
                        _showScripture[randomNumber] += "_";
                    }
                }
            displayScripture();
            }
            }while (decision != "quit");
    }


    public bool isFinished()
    {
        
    }


}

