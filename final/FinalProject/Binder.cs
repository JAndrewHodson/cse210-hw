using System.Reflection.PortableExecutable;

public class Binder
{
    protected List<Character> _characters;

    public void List()
    {
        
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