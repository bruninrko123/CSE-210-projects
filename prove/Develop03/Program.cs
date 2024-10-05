using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";


        
        Reference reference = new Reference();
        

        Scripture scripture = new Scripture(reference, scriptureText);
        scripture.GetDisplayText();

        //do the menu
        Console.WriteLine("Press Enter to continue or 'quit' to finish");
         ConsoleKeyInfo keyInfo = Console.ReadKey();
        do{
           
                Console.Clear();
           
                scripture.HideRandomWords(3);

                scripture.GetDisplayText();

                Console.WriteLine("Press Enter to continue or 'quit' to finish");
                keyInfo = Console.ReadKey();
                
                
                if(scripture.isCompletlyHidden() == true)
                {
                    break;
                }

        }while(keyInfo.Key == ConsoleKey.Enter);

    }
}