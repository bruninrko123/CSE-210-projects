using System.IO;

public class Journal
{
    public  List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry newEntry)
    {
        string data = newEntry._date;
        string pergunta = newEntry._promptText;
        string resposta = newEntry._entryText;

        string message = data + "--" + pergunta + "\n" + resposta;

       _entries.Add(newEntry);
        //Console.WriteLine($"{message}");
        Console.WriteLine($"{_entries}");
    }

    public void DisplayAll()
    {
      Console.WriteLine("tchauuuu");
    foreach (Entry entry in _entries)
    {
      Console.WriteLine("I am in the display all for");
      string pergunta = entry._promptText;
      string data = entry._date;
      string resposta = entry._entryText;
      Console.WriteLine($"{data} -- {pergunta} \n {resposta}");
      Console.WriteLine();
    }
    }

    public void SaveToFile(string filename)
    {

        foreach (Entry entry in _entries)
        {
        Console.WriteLine("What is the name of the file?");
        

        using (StreamWriter outputFile =  new StreamWriter(filename))
        {
          outputFile.WriteLine($"{entry._date} -- {entry._promptText} \n {entry._entryText}");
          outputFile.WriteLine("how are you doing bro?");
        }
        }
    }

    public void LoadFromFile(string filename)
    {

    }
}