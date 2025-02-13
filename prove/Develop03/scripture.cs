
public class Scripture
{
    private List<string> _text;
    
    public Scripture()
    {
        
    }

    public Scripture(string text)
    {
        _text = text.Split(' ').ToList();
        // Console.WriteLine(_text);
    }

    
    
    public bool idFinished()
    {
        return false;
    }

    public bool hideWord()
    {
        return false;
    }
}