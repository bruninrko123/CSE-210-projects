public class Word
{
    private string _text;
    


public Word()
{
    
}
public Word(string text)
{
    _text = text;

    
}


public void Hide()
{  
    if (isHidden() == false)
    {
        int lenghtWord = _text.Length;
        _text = "";
        for (int j = 0; j < lenghtWord; j++)
        {
            _text += "_";

        }
    }
    else
    {

    }
   
}

public void Show()
{

}

public bool isHidden()
{   
    char car1 = _text[0];
    char car2 = _text[1];
    char hiddenChar = '_';
    if (car1 == hiddenChar && car2 == hiddenChar)
    {
        return true;
    }
    else
    {
        return false;
    }
}

public string GetDisplayText()
{
    return _text;
}

}