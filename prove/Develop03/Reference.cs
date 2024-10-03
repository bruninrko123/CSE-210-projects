public class Reference
{
    string _book;
    int _chapter;
    int _verse ;
    int _endVerse;


    public Reference()
    {
        _book = "1Nephi";
        _chapter = 3;
        _verse = 7;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {   
        string display = "";
        if (_endVerse == 0)
            display = $"{_book} {_chapter}:{_verse}";
        else if (_endVerse != 0)
        {
            display = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return display;
    }

}