
public class Scripture
{
    private List<string> _text;
    Verse verse = new Verse();
    
    public Scripture()
    {
        _text = new List<string>();
    }

    public Scripture(string text)
    {
        _text = text.Split(' ').ToList();
        // Console.WriteLine(_text);
    }

    
    
    public bool isFinished()
    {
        bool hidden = verse.isFinished(_text);
        return hidden;
    }

    public bool hideWord()
    {
        return false;
    }
}