public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
        
    }


    public void Start()
    {   
        int decision = 0;
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Create new goal");
            Console.WriteLine("  2.List goals");
            Console.WriteLine("  3.Save goals");
            Console.WriteLine("  4.Load goals");
            Console.WriteLine("  5.Record Events");
            Console.WriteLine("  6.Quit");  
            Console.Write("Select a choice from the menu: ");
            string userChoice= Console.ReadLine();
            decision = int.Parse(userChoice);


            if (decision == 1)
            {
            
                CreateGoal();
            }

        } while (decision != 6);

        
    }

    public void DisplayPlayerInfo()
    {
        throw new NotImplementedException();
    }

    public void ListGoalNames()
    {
        throw new NotImplementedException();
    }

    public void ListGoalDetails()
    {
        throw new NotImplementedException();
    }

    public void CreateGoal()
    {   
        int goaldecision = 0;
        Console.WriteLine("The types of goals are: ");
            Console.WriteLine("  1.Simple Goal");
            Console.WriteLine("  2.Eternal goal");
            Console.WriteLine("  3.Checklist goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalx = Console.ReadLine();
            goaldecision = int.Parse(goalx);

            if (goaldecision == 1)
            {   
                Console.Write("What is the name of your goal? ");
                string goalname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goaldescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal ");
                string pointsNumber = Console.ReadLine();
                int NumberOfPoints = int.Parse(pointsNumber);

                SimpleGoal simpleGoal = new SimpleGoal(goalname,goaldescription,NumberOfPoints);

                _goals.Add(simpleGoal);

            }

            if (goaldecision == 2)
            {
                Console.Write("What is the name of your goal? ");
                string goalname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goaldescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal ");
                string pointsNumber = Console.ReadLine();
                int NumberOfPoints = int.Parse(pointsNumber);

                EternalGoal eternalGoal = new EternalGoal(goalname,goaldescription,NumberOfPoints);

                _goals.Add(eternalGoal);
            }

            if (goaldecision == 3)
            {
                Console.Write("What is the name of your goal? ");
                string goalname = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goaldescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal ");
                string pointsNumber = Console.ReadLine();
                int NumberOfPoints = int.Parse(pointsNumber);
                Console.Write("How many time does this goal need to be accomplished for a bonus? ");
                string howManyTimes = Console.ReadLine();
                int timesForBonus = int.Parse(howManyTimes);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusget = Console.ReadLine();
                int bonusForXTimes = int.Parse(bonusget);

                
                ChecklistGoal checklistGoal = new ChecklistGoal(goalname,goaldescription,NumberOfPoints,timesForBonus,bonusForXTimes);
                _goals.Add(checklistGoal);
            }
    }

    public void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public void SaveGoals()
    {
        throw new NotImplementedException();
    }

    public void LoadGoals()
    {
        throw new NotImplementedException();
    }




}