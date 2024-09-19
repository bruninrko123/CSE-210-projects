using System;

class Program
{
        
        //declaring functions 
       static void DisplayWelcome()
       {
        Console.WriteLine("Welcome to the Program!");
       }


       static string PromptUserName()
       {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
       }


       static int PromptUserNumber()
       {
        Console.Write("Type your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

       }


       static int SquareNumber(int NumberToBeSquared)
       {
        int square = NumberToBeSquared * NumberToBeSquared;
        return square;
       }


       static void DisplayResult(string UserName, int SquaredNumber)
       {
        Console.WriteLine($"The User's name is: {UserName}");
        Console.WriteLine($"The squared number is: {SquaredNumber}");
       }




    static void Main(string[] args)
    {   
        DisplayWelcome();
        string Nome = PromptUserName();
        int Numero = PromptUserNumber();
        int Square = SquareNumber(Numero);
        DisplayResult(Nome, Square);

    }
}