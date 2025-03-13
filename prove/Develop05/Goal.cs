public abstract class Goal
{
    public int _points;
    public string _name;
    public string _desc;

    public Goal()
    {
        _points = 0;
        _name = "";
        _desc = "";
    }
    
    public Goal(int points, string name, string desc)
    {
        _points = points;
        _name = name;
        _desc = desc;
    }
    public abstract bool IsComplete();

    public abstract void Display();

    public virtual int GetPoints()
    {
        return _points;
    }

    public abstract int SetCompleted();

    public abstract Goal GetRep();


}