using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    
    {

      //Declare variables
      int menuChoice = 0;

      //while
       while (menuChoice != 5)
       {

        //doing the menu
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        
        menuChoice = int.Parse(Console.ReadLine());

        


      if (menuChoice == 1)
      {
        //pra pular linha
        Console.WriteLine();


        // print the prompt on the screen
        PromptGenerator printprompt = new PromptGenerator();
      
        string Question = printprompt.GetRandomPrompt();



        //get entries
        string answer = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._entryText = answer;

        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString();
        
        newEntry._date = formattedDate;

        newEntry._promptText = Question;

        newEntry.Display();


        // add entry into the entries list

        Journal journal = new Journal();
        journal.AddEntry(newEntry);
        //journal._entries.Add(newEntry);

        Console.WriteLine($"{journal._entries}");

      }

      else if (menuChoice == 2)
      {
          Console.WriteLine("oiiiiii");
        Journal jo1 = new Journal();
        jo1.DisplayAll();
        
        //Journal jo1 = new Journal();
      //foreach (Entry mensag in jo1._entries)
      //{
        
        //Console.WriteLine($"{mensag}");
      //}
      }

      else if (menuChoice == 3)
      { 
        Console.Write("What is the name of the fiel to read? ");
        string fileToBeRead = Console.ReadLine();
        Journal read = new Journal();
        read.LoadFromFile(fileToBeRead);
        
      }
    


      else if (menuChoice == 4)
      {   
          Console.WriteLine("qual e o nome do arquivo? ");
          string nameOfTheFile = Console.ReadLine();
          Journal save = new Journal();
          save.SaveToFile(nameOfTheFile);
      


        
      }





    }
        //pular linha denovo
        Console.WriteLine();
    }
}
 
    
      

        
