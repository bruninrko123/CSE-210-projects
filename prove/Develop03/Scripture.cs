public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


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
        List<int> hiddenwords = new List<int>();
        int hiddencounter = 0;
        int lengthList = _words.Count;
        do
        {
            
            Random random = new Random();
            int randomNumber = random.Next(0, lengthList);
            if (_words[randomNumber].isHidden() == false)
            {
                hiddenwords.Add(randomNumber);
                
                hiddencounter++;
            }
        } while(hiddencounter < numberToHide);

        for (int j = 0; j < hiddencounter; j++)
            _words[hiddenwords[j]].Hide();
            

            
       
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
        int finishCounter = 0;
        int lengthList = _words.Count;
        for (int g = 0; g < lengthList; g++)
        {   
            if(_words[g].isHidden() == true)
            {
                finishCounter = finishCounter + 1;
            }
            Random random = new Random();
            int randomNumber = random.Next(0, lengthList);

        }

        if (finishCounter >= lengthList)
        {
            return true;
        }
          
        else
        {
            return false;
        }
    }

   


}