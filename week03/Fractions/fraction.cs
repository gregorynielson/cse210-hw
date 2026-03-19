


public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
        
    }

    public int SetTop(int top)
    {
        _top = top;
        return _top;
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }

    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        return _bottom;
    }
}