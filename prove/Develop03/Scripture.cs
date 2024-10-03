public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();


   public Scripture()
    {

    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        

        string[] words = text.Split(" ");
       


        foreach (string w in words)
        {   
            Word word = new Word(w);
            _words.Add(word);
        }
        
        
    }

    public void HideRandomWords(int numberToHide)
    {
        int lengthList = _words.Count;
         for (int g = 0; g < numberToHide; g++)
        {   

            Random random = new Random();
            int randomNumber = random.Next(0, lengthList - 1);

            _words[randomNumber].Hide();
            

            
        }
    }

    public string GetDisplayText()
    {   //display reference
        Console.WriteLine(_reference.GetDisplayText());
        //display scripture
        foreach (Word w in _words)
        {   
            string singleWord = w.GetDisplayText();
            Console.Write(singleWord + " ");
            
        }
        Console.WriteLine();
        return _reference.GetDisplayText();
    }
    

    public bool isCompletlyHidden()
    {
        return false;
    }

   


}