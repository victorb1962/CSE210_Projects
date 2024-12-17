public class CyclingActivity : Activity
{
    int _speed;
    public CyclingActivity(string date, int length, int speed) : base (date, length)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        return Speed() / 60 * _length;
    }
    public override double Speed()
    {
        return this._speed;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
    public override void Summary()
    {
        _activity = "Cycling";
        base.Summary();
    }
}