public class Verse 
{
    private List<string> _verse;

    Word wordRef = new Word();
    public Verse()
    {

    }

    public Verse(string text)
    {
        _verse = text.Split(' ').ToList();
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