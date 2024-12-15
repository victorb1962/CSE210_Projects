using System;

public class HealthGoal : Goal
{
    // Attributes
    private string _type = "Health Goal";
    private bool _status;

    // Constructors
    public HealthGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public HealthGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type};{GetName()};{GetDescription()};{GetPoints()};{_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type};{GetName()};{GetDescription()};{GetPoints()};{_status}");
    }
    public override void RecordEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

}