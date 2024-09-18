using System;

class Program
{
    static void Main(string[] args)
    {   
        // declaring the letter variable
        string letter = "";

        // Get the grade percentage from the user
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        
        // decide which letter the grade means

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        // add the + or - or nothing to the letter
        int signTester = gradePercentage % 10;
        if (signTester >= 7 && letter != "A" && letter != "F")
        {
            letter = letter + "+";
        }

        else if (signTester <= 3 && letter != "F")
        {
            letter = letter + "-";
        }
        else
        {

        }


        //print the letter
        Console.WriteLine($"Your grade is: {letter}");



        // check wheter the student passed the class
        Console.WriteLine();
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass this class. Keep trying and trust the lord. You can do it again and succeed");
        }
    }
};