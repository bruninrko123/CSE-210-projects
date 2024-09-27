using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
         Random random = new Random();
        int randomNumber  = random.Next(0,3);
        Console.WriteLine(randomNumber);
    }
}