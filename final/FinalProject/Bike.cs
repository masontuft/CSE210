public class Bike : Shop
{
    public int Id;
    public int ChainUsedMiles;
    public int CassetteUsedMiles;
    public int FrontForkUsedMiles;
    public int RearShockUsedMiles;
    public int ChainRingUsedMiles;
    public int BottomBracketUsedMiles;
    public int SealantUsedHours;
    public int BrakePadsUsedMiles;
    public int BrakeRotorsUsedMiles;
    public int TiresUsedMiles;
    public string StravaBikeId;
    public string StravaBikeName;
    public int TotalMiles;
    public int StravaUserId;
    public int DropperUsedMiles;
    private List<Part> bike = new List<Part>();
    // Define properties and methods for the Bikes class here
    public void Display()
    {
        Console.WriteLine("Bike ID: " + Id);
        Console.WriteLine("Strava Bike ID: " + StravaBikeId);
        Console.WriteLine("Strava Bike Name: " + StravaBikeName);
        Console.WriteLine("Strava User ID: " + StravaUserId);
        Console.WriteLine("Chain Used Miles: " + ChainUsedMiles);
        Console.WriteLine("Cassette Used Miles: " + CassetteUsedMiles);
        Console.WriteLine("Front Fork Used Miles: " + FrontForkUsedMiles);
        Console.WriteLine("Rear Shock Used Miles: " + RearShockUsedMiles);
        Console.WriteLine("Chain Ring Used Miles: " + ChainRingUsedMiles);
        Console.WriteLine("Bottom Bracket Used Miles: " + BottomBracketUsedMiles);
        Console.WriteLine("Sealant Used Hours: " + SealantUsedHours);
        Console.WriteLine("Brake Pads Used Miles: " + BrakePadsUsedMiles);
        Console.WriteLine("Brake Rotors Used Miles: " + BrakeRotorsUsedMiles);
        Console.WriteLine("Tires Used Miles: " + TiresUsedMiles);
        Console.WriteLine("Total Miles: " + TotalMiles);
        Console.WriteLine("Dropper Used Miles: " + DropperUsedMiles);
    }
}
