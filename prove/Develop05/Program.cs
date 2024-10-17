using System;

class Program
{
    static void Main(string[] args)
    {   
        

        Console.WriteLine("Hello Develop05 World!");
        
        Console.WriteLine("Menu Options");
        int decision = 0;
        do
        {
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
        Console.WriteLine("Selece a choice from the menu");
        string option = Console.ReadLine();
        decision = int.Parse(option);



        if (decision == 1)
        {   
            
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();

            
        }

        if (decision == 2)
        {
            ReflectionAcitivity reflectionAcitivity = new ReflectionAcitivity();
            reflectionAcitivity.Run();
        }

        if (decision == 3)
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        }while (decision != 4);
    }
}