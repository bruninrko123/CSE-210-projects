public class Reference
{
    private string _scriptureReference;
    private string _book;
    private string _chapter;
    private string _verse1;
    private string _verse2;


public Reference()
{
    _scriptureReference = "1 Nephi 3:7";
    _book = "1 Nephi";
    _chapter = "3";
    _verse1 = "7";
    _verse2 = "";
}
public Reference(string book, string chapter, string verse)
{
    _scriptureReference = $"{book} {chapter}:{verse}";
    _book = book;
    _chapter = chapter;
    _verse1 = verse;
    _verse2 = "";
}

public Reference(string book,string chapter, string verse1, string verse2)
{
    _scriptureReference = $"{book} {chapter}:{verse1}-{verse2}";
    _book = book;
    _chapter = chapter;
    _verse1 = verse1;
    _verse2 = verse2;
}




   public void displayReference()
{
    Console.WriteLine(_scriptureReference);
}

}