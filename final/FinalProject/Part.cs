class Part : Bike
{
    public string Name;
    public int UsedMiles;

    public Part(string name, int usedMiles)
    {
        Name = name;
        UsedMiles = usedMiles;
    }

    public Part()
    {
        Name = "Unknown";
        UsedMiles = 0;
    }
    
}