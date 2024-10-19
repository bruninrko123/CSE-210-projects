


using System;
using System.IO;
using System.Collections.Generic;
 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
 
    public Journal() { }
 
    // Adds an entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine($"Number of entries: {_entries.Count}");
    }
 
    // Displays all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }
 
    // Saves all entries to a file
    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter("test.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Entries saved to {"test.txt"}.");
    }
 
    // Loads entries from a file and adds them to the journal
    public void LoadFromFile()
    {   
        
        string[] lines = File.ReadAllLines("test.txt");

        foreach (string line in lines)
        {   Console.WriteLine("here again");
            string[] parts = line.Split('|');
 
            if (parts.Length > 1)
            {   
                Console.WriteLine("inside the if statement");
                string dateAtTheTime = parts[0];
                string promptQuestion = parts[1];
                string answerToPrompt = parts[2];
 
                Entry loadedEntry = new Entry(dateAtTheTime, promptQuestion, answerToPrompt);
                
                AddEntry(loadedEntry);
            }
        }
        Console.WriteLine($"Entries loaded from {"test.txt"}.");
    }
}