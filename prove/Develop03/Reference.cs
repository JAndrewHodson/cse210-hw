public class Reference
{
    private string _book;
    private int _chapter;
    private int _fVerse;
    private int _lVerse;

    public Reference(string b, int c, int fV, int lV)
    {
        _book = b;
        _chapter = c;
        _fVerse = fV;
        _lVerse = lV;
    }

    public Reference(string b, int c, int v)
    {
        _book = b;
        _chapter = c;
        _fVerse = v; 
    }

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _fVerse = 0; 
        _lVerse = 0;
    }

    public void ReferenceDisplay(string b, int c, int v)
    {
        Console.WriteLine($"{b} {c}:{v}");
    }

    public void ReferenceDisplay(string b, int c, int fV, int lV)
    {
        Console.WriteLine($"{b} {c}:{fV}-{lV}");
    }
}