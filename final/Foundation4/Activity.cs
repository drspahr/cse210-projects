class Activity
{
    private float _distance;
    private float _speed;
    private string _time;
    private string _date;

    // Constructor
    public Activity(float dis, float speed, string time, string date)
    {

    }

    public Activity(float speed, string time)
    {
        
    }

    // Method
    public virtual float CalcSpeed()
    {
        float speed = 0;
        return speed;
    }

    public virtual float CalcPace()
    {
        float pace = 0;
        return pace;
    }

    public virtual void GetSummary()
    {

    }
}