using System.IO;

public class Entry
{
    public string _date;

    public string _promptText;

    public string _entryText;

    
public Entry()
{
    
}
public Entry(string date, string promptText, string entryText)
{
    _date = date;
    _promptText = promptText;
    _entryText = entryText;
}
   
    public void Display()
    {
       Console.WriteLine($"Date: {_date} -- {_promptText} \n{_entryText}" );

        return;
    }
}