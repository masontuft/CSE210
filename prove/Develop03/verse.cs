public class Verse 
{

    Word wordRef = new Word();
    public Verse()
    {

    }

    public Verse(List<string> text)
    {
        
    }

    public bool isFinished(List<string> _text)
    {
        bool hidden = false;
        foreach(string word in _text)
        {
            hidden = wordRef.isHidden(word);
            if(!hidden)
            {
                break;
            }
        }
        return hidden;
    }

    public bool hideWord()
    {
        return false;
    }
}