
public class Word 
{
    public Word()
    {

    }

    public Word(string text)
    {
        
    }

    public bool isHidden(string word)
    {
        if (word.Contains('_'))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public string setHidden(string word)
    {
        string hiddenWord = "";
        foreach(char letter in word)
        {
            hiddenWord += '_';
        }
        return hiddenWord;

    }

    // public static implicit operator List<object>(Word v)
    // {
    //     throw new NotImplementedException();
    // }
}