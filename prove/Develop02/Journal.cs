using System.IO;

public class Journal
{
    public  List<Entry> _entries = new List<Entry>() ;

public Journal()
{
  
}

    public void AddEntry(Entry newEntry)
    {
        //string data = newEntry._date;
        //string pergunta = newEntry._promptText;
        //string resposta = newEntry._entryText;

        //string message = data + "--" + pergunta + "\n" + resposta;

       _entries.Add(newEntry);
        Console.Write("This is the lenght of the list: ");
        Console.WriteLine(_entries.Count);
        //Console.WriteLine($"{message}");
        Console.WriteLine($"{_entries}");
    }

    public void DisplayAll()
    {
      Console.WriteLine("tchauuuu");
      if (_entries.Count == 0)
      {
        Console.WriteLine("the list is empyt");
      } 
      else
      {
        foreach (Entry entry in _entries)
        {
          entry.Display();
        }
      }
    //if _entries.Count  
    //foreach (Entry entry in _entries)
    //{
      //Console.WriteLine("I am in the display all for");
      //string pergunta = entry._promptText;
      //string data = entry._date;
      //string resposta = entry._entryText;
      //Console.WriteLine($"{data} -- {pergunta} \n {resposta}");
      //Console.WriteLine();
    //}
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine(" Estou no save file");

        using (StreamWriter outputFile =  new StreamWriter(filename))
        {

          foreach (Entry entry in _entries)
          {
            Console.WriteLine("What is the name of the file?");
        

        //using (StreamWriter outputFile =  new StreamWriter(filename))
        //{
            outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
          
        //}
          }
        }
    }

    public void LoadFromFile(string filename)
    {
      string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
          string[] parts = line.Split(",");

          string dateAtTheTime = parts[0];
          string promptQuestion =parts[1];
          string answerToPrompt = parts[2];
        }
    }
}