public class Profile
{
    private List<Goal> _goals = new List<Goal>();

    private double _score = 0;

    public double getScore()
    {
        return _score;
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.Display();
            index = index + 1;
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void Event()
    {
        Console.WriteLine("The goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.EventList();
            index = index + 1;
        }
    }

    public void CompleteGoal(int index)
    {
        _score = _score + _goals[index-1].Complete();
    }

    public void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        bool firstLine = true;

        foreach (string line in lines)
        {
            if (firstLine)
            {
                _score = double.Parse(line);
                firstLine = false;
            } else 
            {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] goalData = line.Split("~|~");

            string name = goalData[0];
            string description = goalData[1];
            double points = double.Parse(goalData[2]);

            if (goalType == "SimpleGoal")
            {
                
                bool completed = bool.Parse(goalData[3]);

                Goal goal = new SimpleGoal(name, description, points, completed);
                _goals.Add(goal);
            } else if (goalType == "InfiniteGoal")
            {
                int timesCompleted = int.Parse(goalData[3]);
                Goal goal = new InfiniteGoal(name, description, points, timesCompleted);
                _goals.Add(goal);
            } else if (goalType == "ChecklistGoal")
            {
                double completionBonus = double.Parse(goalData[3]);
                int timesToComplete = int.Parse(goalData[4]);
                int timesCompleted = int.Parse(goalData[5]);

                Goal goal = new ChecklistGoal(name, description, completionBonus, timesToComplete, points, timesCompleted);
                _goals.Add(goal);
            }
            }
        }
    }
}