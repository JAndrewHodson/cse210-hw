using System.Reflection.PortableExecutable;

public class Binder
{
    private List<Character> _characters = [];

    public Binder()
    {
        _characters = [];
    }

    public void List()
    {
        int index = 1;
        foreach (Character character in _characters)
        {
            string data = character.List();
            Console.WriteLine($"{index}. {data}");
            index = index + 1;
        }
    }

    public Character GetCharacter(int index)
    {
        return _characters[index-1];
    }

    public void AddCharacter(Character character)
    {
        _characters.Add(character);
    }
}