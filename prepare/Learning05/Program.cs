using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bruno", "Programming");
        Console.WriteLine(assignment.GetSummary());

        
        MathAssignment mathAssignment = new MathAssignment("21", "10-22", "Thamara", "Marketing");
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingAssignment = new WritingAssignment("'What can we do about it?'","Marco", "Poverty in Africa");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}