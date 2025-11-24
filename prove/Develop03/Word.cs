public class Word
{
    private string _word;

    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Display()
    {
        if(_hidden)
        {
            int stringLength = _word.Length;
            for (int i = 1; i <= stringLength; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.WriteLine(_word);
        }
    }
}
