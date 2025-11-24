public class Scripture
{
    List<Word> _scriptureBody = new List<Word>();

    public Scripture(List<string> scripture)
    {
        foreach(string word in scripture)
        {
            Word newWord = new Word(word);
            _scriptureBody.Add(newWord);
        }
    }

    public void Display()
    {
        foreach(Word word in _scriptureBody)
        {
            word.Display();
        }
    }

    public void Hide()
    {
        Random rnd = new Random();
        int index;

        for (int i = 0; i < 3; i++)
        {
            index = rnd.Next(_scriptureBody.Count);
            _scriptureBody[index].Hide();
            
        }
    }
}