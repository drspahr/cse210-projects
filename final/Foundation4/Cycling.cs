class Cycle : Activity
{
    // Constructor
    public Cycle(float dis, float speed, string time, string date) : base(dis, speed, time, date)
    {

    }

    public override float CalcSpeed()
    {
        return base.CalcSpeed();
    }

    public override float CalcPace()
    {
        return base.CalcPace();
    }
}