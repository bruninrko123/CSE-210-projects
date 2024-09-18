using System;

class Program
{
    static void Main(string[] args)
    {   
        string playAgain = "";
        do{
            int counter = 0;
            int UserGuess = 0;
            // Get the magic number from the user
            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1,101);
            


            //Console.Write("What is the Magic Number? ");
            //string UserInputMagicNumber = Console.ReadLine();
            //int MagicNumber = int.Parse(UserInputMagicNumber);

            // getting the user's guess
            do{
                Console.Write("Guess a number: ");
                string UserInputGuess = Console.ReadLine();
                UserGuess = int.Parse(UserInputGuess);
                counter++;
                // Check whether the user should guess higher, lower or if he got it right

                if (MagicNumber > UserGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (MagicNumber < UserGuess)
                {
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine($"you got it right! It took you {counter} guesses");
                    // do the do you wanna play again thing
                    Console.WriteLine();
                    Console.Write("Do you want to play again? (yes or no)");
                    playAgain = Console.ReadLine();
                }
                
            } while (UserGuess != MagicNumber);
        } while(playAgain.ToLower() == "yes");
    }
}