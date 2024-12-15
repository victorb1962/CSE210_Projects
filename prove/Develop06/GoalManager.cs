using System;
using System.IO;

public class GoalManager

{
    // Attributes
    private List<Goal> _goals = new List<Goal>();
    private int _score;


    // Constructors
    public GoalManager()
    {
        _score = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public void AddPoints(int points)
    {
        _score += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _score += bonusPoints;
    }
    public void SetScore(int score)
    {
        _score = score;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    // Methods
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nThe goals are: ");

            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished? ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordEvent(_goals);

        Console.WriteLine($"You now have {GetScore()} points! ");
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name ONLY for the goal file? (.txt assumed) ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetScore());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name ONLY for the goal file? (.txt assumed) ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int score = int.Parse(readText[0]);
            SetScore(score);
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split(";");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Checklist Goal")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Health Goal")
                {
                    HealthGoal hGoal = new HealthGoal(type, name, description, points, status);
                    AddGoal(hGoal);
                }
            }
        }
        else
        {
            Console.Write("The goal file was not found.\n");
        }
    }

}