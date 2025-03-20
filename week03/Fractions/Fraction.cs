public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;//This a way to set by default
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;//This a way to set
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;//This a way to set from user
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        double DecimalValue = (double)_top / (double)_bottom;
        return DecimalValue;
    }
}