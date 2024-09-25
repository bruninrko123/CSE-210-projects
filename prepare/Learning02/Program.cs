using System;

class Program
{
    static void Main(string[] args)
    {
        

        Job job1 = new Job();

        job1._jobTitle = "English Teacher";
        job1._company = "YourTurn";
        job1._startYear = 2024;
        job1._endYear = 2025;

        //Console.WriteLine($"{job1._company}");
        //job1.DisplayCompanyInfo();



         Job job2 = new Job();

        job2._jobTitle = "Software Engineer";
        job2._company = "X";
        job2._startYear = 2026;
        job2._endYear = 2030;
        //Console.WriteLine($"{job2._company}");
        //job2.DisplayCompanyInfo();
        

        Resume John = new Resume();

        John._name = "John";
        John._JobsList.Add(job1);
        John._JobsList.Add(job2);

        //Console.WriteLine($"{John._JobsList[0]._jobTitle}");
        John.DisplayResume();
    }
}