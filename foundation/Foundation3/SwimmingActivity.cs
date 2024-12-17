public class SwimmingActivity : Activity
{
    int _laps;
    public SwimmingActivity(string date, int length, int laps) : base (date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return this._laps * 50.0 / 1000 * 0.62;
    }
    public override double Speed()
    {
        return Distance() / _length * 60;
        // return _length / this._laps;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
    public override void Summary()
    {
        _activity = "Swimming";
        base.Summary();
    }
}