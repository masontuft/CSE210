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
    public Bike()
    {
        Id = 0;
        ChainUsedMiles = 0;
        CassetteUsedMiles = 0;
        FrontForkUsedMiles = 0;
        RearShockUsedMiles = 0;
        ChainRingUsedMiles = 0;
        BottomBracketUsedMiles = 0;
        SealantUsedHours = 0;
        BrakePadsUsedMiles = 0;
        BrakeRotorsUsedMiles = 0;
        TiresUsedMiles = 0;
        StravaBikeId = "Unknown";
        StravaBikeName = "Unknown";
        TotalMiles = 0;
        StravaUserId = 0;
        DropperUsedMiles = 0;
    }
    // public Bike(
    //     int id, int chainUsedMiles, 
    //     int cassetteUsedMiles, int frontForkUsedMiles, 
    //     int rearShockUsedMiles, int chainRingUsedMiles, 
    //     int bottomBracketUsedMiles, int sealantUsedHours, 
    //     int brakePadsUsedMiles, int brakeRotorsUsedMiles, 
    //     int tiresUsedMiles, string stravaBikeId, 
    //     string stravaBikeName, int totalMiles, 
    //     int stravaUserId, int dropperUsedMiles)
    // {
    //     Id = id;
    //     ChainUsedMiles = chainUsedMiles;
    //     CassetteUsedMiles = cassetteUsedMiles;
    //     FrontForkUsedMiles = frontForkUsedMiles;
    //     RearShockUsedMiles = rearShockUsedMiles;
    //     ChainRingUsedMiles = chainRingUsedMiles;
    //     BottomBracketUsedMiles = bottomBracketUsedMiles;
    //     SealantUsedHours = sealantUsedHours;
    //     BrakePadsUsedMiles = brakePadsUsedMiles;
    //     BrakeRotorsUsedMiles = brakeRotorsUsedMiles;
    //     TiresUsedMiles = tiresUsedMiles;
    //     StravaBikeId = stravaBikeId;
    //     StravaBikeName = stravaBikeName;
    //     TotalMiles = totalMiles;
    //     StravaUserId = stravaUserId;
    //     DropperUsedMiles = dropperUsedMiles;
    // }
    public void BikesMenu(List<Bike> Bikes)
    {
        int i = 0;
        foreach (Bike bike in Bikes)
        {
            Console.WriteLine();
            Console.WriteLine($"Bike number: {i}");
            Console.WriteLine($"{bike.Id}");
            Console.WriteLine($"{bike.StravaBikeId}");
            Console.WriteLine($"{bike.StravaBikeName}");
            Console.WriteLine($"{bike.StravaUserId}");
            i++;
        }
    }

    // public void FindBike(string id)
    // {
    //     foreach (Bike bike in Bikes)
    //     {
    //         if (bike.StravaBikeId == id)
    //         {
    //             bike.Display();
    //         }
    //     }
    // }
    public void Display()
    {
        Console.WriteLine("ID: " + Id);
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
