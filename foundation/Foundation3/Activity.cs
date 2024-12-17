public abstract class Activity
{
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected string _date;
    protected int _length;
    protected string _activity;

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public virtual void Summary()
    {
        
        Console.WriteLine($"{_date,-12} {_activity,-8} ({_length,3} min) - Distance {Distance(),4:F1} miles, Speed {Speed(),4:F1} mph, Pace {Pace(),4:F1} min per mile");
    }
}