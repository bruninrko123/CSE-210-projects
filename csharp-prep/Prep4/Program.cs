using System;

class Program
{
    static void Main(string[] args)
    {   // declaring variables
        int number;
        int sumKeeper = 0;
        int helper = 0;
        long smallestPositiveHelper = 999999;
        List<int> numbers = new List<int>();
        // getting a list of numbers from the user 
        Console.WriteLine("Enter a list of numbers. Type 0 whe you are done");
        do{
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while(number != 0);

        //get the sum, average and the largest number of the list

        foreach (int x in numbers)
        {   
            // get the largest number
            if (x > helper)
            {
               helper = x;
            }

            else if (x > 0 && x < smallestPositiveHelper)
            {
                smallestPositiveHelper = x;
            }
            // sum numbers
            sumKeeper = sumKeeper + x;

        }
        Console.WriteLine();
        Console.WriteLine($"The sum of the numbers is: {sumKeeper}");
        Console.WriteLine($"The average is {sumKeeper / numbers.Count}");
        Console.WriteLine($"The largest number is {helper}");
        Console.WriteLine($"The smallest positive number is {smallestPositiveHelper}");
        Console.Write("The sorted list is: ");
        numbers.Sort();
        foreach (int piece in numbers)
        {   
            
            Console.Write($"{piece}, ");
        }

    }
}