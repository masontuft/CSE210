using System;

public class Entry
{
    public string _entry;
    public string _prompt;

    public DateOnly _date;

    public void Display()
    {
        Console.WriteLine(_prompt + " " + _entry);
    }
}