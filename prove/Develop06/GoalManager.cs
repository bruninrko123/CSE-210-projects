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

            if (decision == 2)
            {
                ListGoalDetails();
            }

            if (decision == 3)
            {
                SaveGoals();
            }

            if (decision == 4)
            {
                LoadGoals();
            }

            if (decision == 5)
            {
                RecordEvent();
            }

            

        } while (decision != 6);

        
    }

    public void DisplayPlayerInfo()
    {
        throw new NotImplementedException();
    }

    public void ListGoalNames()
    {   
        int counter = 0;
        foreach (Goal g in _goals)
        {   
            counter++;
            string goaldetails = g.GetDetailsString();
            string[] words = goaldetails.Split(',');
            string name = words[0];
            Console.WriteLine($"{counter}.{name}");
        }
    }

    public void ListGoalDetails()
    {   
        foreach (Goal g in _goals)
        {   
            //declaring variables to use in the exeption
            string target = "";
            string completed = "";
            
            

            //getting the details
            string goaldetails = g.GetDetailsString();
            
            string[] words = goaldetails.Split(',');
            string name = words[0];
            string description = words[1];
            string points = words[2];
            string iscomplete = words[3];
            Console.WriteLine(words[3]);
            string brackets = "";
            if (iscomplete == "False")
            {
                brackets = "[ ]";
            }
            else
            {
                brackets = "[x]";
            }

            // testing if it is a checklist goal
            int wordCount = words.Length;

            if (wordCount > 4)
            {
                target = words[4];
                completed = words[5];
                
                Console.WriteLine($"{brackets} {name} ({description} -- Currently completed: {completed}/{target})");
            }
           
           else
           {
                Console.WriteLine($"{brackets} {name} ({description})");
            
           }
        
            
        }
        
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
                // int NumberOfPoints = int.Parse(pointsNumber);

                SimpleGoal simpleGoal = new SimpleGoal(goalname,goaldescription,pointsNumber);

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
                // int NumberOfPoints = int.Parse(pointsNumber);

                EternalGoal eternalGoal = new EternalGoal(goalname,goaldescription,pointsNumber);

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
                // int NumberOfPoints = int.Parse(pointsNumber);
                Console.Write("How many time does this goal need to be accomplished for a bonus? ");
                string howManyTimes = Console.ReadLine();
                int timesForBonus = int.Parse(howManyTimes);
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusget = Console.ReadLine();
                int bonusForXTimes = int.Parse(bonusget);

                
                ChecklistGoal checklistGoal = new ChecklistGoal(goalname,goaldescription,pointsNumber,timesForBonus,bonusForXTimes);
                _goals.Add(checklistGoal);
            }
    }

    public void RecordEvent()
    {
        
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string accomplished = Console.ReadLine();
        int accomplishedGoal = int.Parse(accomplished);
        
        string pointsToScore = _goals[accomplishedGoal - 1].RecordEvent();

        int TimelyScore = int.Parse(pointsToScore);

        _score += TimelyScore;

        Console.WriteLine($"\nYou have {_score} points.");

        

    }

    public void SaveGoals()
    {
        using(StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {   
        
        using (StreamReader reader = new StreamReader("goals.txt"))
        {

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }


    // public Goal createGoalObject(string[] details)
    // {
    //     details.Split('','');
    //     string name = details[0];

    // }

}