using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    
    {
      Journal journal = new Journal();
      //Declare variables
      int menuChoice = 0;

      //while
       while (menuChoice != 5)
       {

        //doing the menu
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
        
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
        

        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString();
        
        Entry newEntry = new Entry(formattedDate, Question, answer);

        

        newEntry.Display();


        // add entry into the entries list

        
        journal.AddEntry(newEntry);
        //_entries.Add(newEntry);

        Console.WriteLine($"{journal._entries}");

      }

      else if (menuChoice == 2)
      {
        
        
        journal.DisplayAll();
        
        
      }

      else if (menuChoice == 3)
      { 
        Console.Write("What is the name of the fiel to read? ");
        string fileToBeRead = Console.ReadLine();
        
        journal.LoadFromFile(fileToBeRead);
        
      }
    


      else if (menuChoice == 4)
      {   
          Console.WriteLine("what is the name of the file? ");
          string nameOfTheFile = Console.ReadLine();
          
          journal.SaveToFile(nameOfTheFile);
      


        
      }





    }
        //pular linha denovo
        Console.WriteLine();
    }
}
 
    
      

        
