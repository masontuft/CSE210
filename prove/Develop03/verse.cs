public class Verse 
{
    private List<string> _verse;

    private Random _random = new Random();

    Word wordRef = new Word();
    public Verse()
    {
        _verse = new List<string>();
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
            if(hidden == false)
            {
                return false;
            }
            else{
                hidden = true;
            }
            
        }
        return hidden;
        
    }

    public void hideWord(List<string> text)
    {

        // if (text.Count == 0)
        // {
        //     return;  // Nothing to hide
        // }

        int count = 1;
        while(count < 3)
        {
            int verseLength = text.Count;
            int index = _random.Next(0, verseLength);
            if (wordRef.isHidden(text[index]) == true)
            {
                index = _random.Next(0, verseLength);
            }
            else
            {
                text[index] = wordRef.setHidden(text[index]);
                count++;
            }
            
        }
    }
}