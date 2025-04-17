public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public string GetDate() => _date;
    public int GetLength() => _lengthInMinutes;

    public abstract double GetDistance();  // km or miles
    public abstract double GetSpeed();     // km/h or mph
    public abstract double GetPace();      // min/km or min/mile

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
