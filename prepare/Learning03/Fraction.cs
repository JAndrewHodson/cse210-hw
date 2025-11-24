public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int _topInput)
    {
        _top = _topInput;
        _bottom = 1;
    }

    public Fraction(int _topInput, int _bottomInput)
    {
        _top = _topInput;
        _bottom = _bottomInput;
    }

    public string GetFractionString()
    {
        return _top+"/"+_bottom;
    }

    public double GetDecimalString()
    {
        return (double)_top / (double)_bottom;
    }
}
