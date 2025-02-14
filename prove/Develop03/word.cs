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

    public void setHidden()
    {
        
    }


}