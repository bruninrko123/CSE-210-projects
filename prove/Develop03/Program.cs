using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference r1 = new Reference();
        r1.displayReference();
        Scripture s1 = new Scripture();
        s1.displayScripture();

        Reference r2 = new Reference("John", "3", "17");
        r2.displayReference();

        Reference r3 = new Reference("Proverbs", "3", "5", "6");
        r3.displayReference();

        //define which scripture to use
        Scripture scripture = new Scripture();


        Scripture hiding = new Scripture();
        hiding.Hide();


    }
}