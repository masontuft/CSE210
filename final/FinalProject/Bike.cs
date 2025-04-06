public class Bike
{
    public int Id;
    public int ChainUsedMiles;
    public int ChainMiles;
    public int CassetteUsedMiles;
    public int CassetteMiles;
    public int FrontForkUsedMiles;
    public int FrontForkMiles;
    public int RearShockUsedMiles;
    public int RearShockMiles;
    public int ChainRingUsedMiles;
    public int ChainRingMiles;
    public int BottomBracketUsedMiles;
    public int BottomBracketMiles;
    public int SealantUsedHours;
    public int SealantRefreshHours;
    public int BrakePadsUsedMiles;
    public int BrakePadsMiles;
    public int BrakeRotorsUsedMiles;
    public int BrakeRotorsMiles;
    public int TiresUsedMiles;
    public int TiresMiles;
    public string StravaBikeId;
    public string StravaBikeName;
    public int TotalMiles;
    public int StravaUserId;
    public int DropperUsedMiles;
    public int DropperMiles;
    private List<Part> bike = new List<Part>();

    public Chain Chain;
    public Cassette Cassette;
    public FrontFork FrontFork;
    public RearShock RearShock;
    public ChainRing ChainRing;
    public BottomBracket BottomBracket;
    public Sealant Sealant;
    public BrakePads BrakePads;
    public BrakeRotors BrakeRotors;
    public Tires Tires;
    public Dropper Dropper;
    public BrakeBleed BrakeBleed;
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

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("Strava Bike Name: " + StravaBikeName);
        Console.WriteLine();
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Strava Bike ID: " + StravaBikeId);
        Console.WriteLine("Strava User ID: " + StravaUserId);

        if (Chain != null) Console.WriteLine(Chain.ToString());
        if (Cassette != null) Console.WriteLine(Cassette.ToString());
        if (FrontFork != null) Console.WriteLine(FrontFork.ToString());
        if (RearShock != null) Console.WriteLine(RearShock.ToString());
        if (ChainRing != null) Console.WriteLine(ChainRing.ToString());
        if (BottomBracket != null) Console.WriteLine(BottomBracket.ToString());
        if (Sealant != null) Console.WriteLine(Sealant.ToString());
        if (BrakePads != null) Console.WriteLine(BrakePads.ToString());
        if (BrakeRotors != null) Console.WriteLine(BrakeRotors.ToString());
        if (Tires != null) Console.WriteLine(Tires.ToString());
        if (Dropper != null) Console.WriteLine(Dropper.ToString());
        if (BrakeBleed != null) Console.WriteLine(BrakeBleed.ToString());

    }

    public void DisplayBikesByUserId(List<Bike> bikes, int userIndex)
    {
        bool found = false;
        int userId = User.UsersList[userIndex - 1].StravaUserId;
        Console.WriteLine($"User First Name: {User.UsersList[userIndex - 1].FirstName}");
        Console.WriteLine($"User Last Name: {User.UsersList[userIndex - 1].LastName}");
        Console.WriteLine($"\nBikes for Strava User ID: {userId}\n");
        
        
        foreach (Bike bike in bikes)
        {
            if (bike.StravaUserId == userId)
            {
                bike.Display();
                Console.WriteLine(); 
                found = true;
            }
        }
        
        if (!found)
        {
            Console.WriteLine($"No bikes found for user ID {userId}");
        }
    }
    public void DisplayBikeByIndex(List<Bike> bikes, int index)
    {
        if (index >= 0 && index < bikes.Count)
        {
            bikes[index].Display();
        }
        else
        {
            Console.WriteLine("Invalid bike index.");
        }
        
    }
    public string GetBike()
    {
        return $"Bike ID: {Id}, \n" +
               $"StravaBikeId: {StravaBikeId}, \n" +
               $"TotalMiles: {TotalMiles}, \n" +
               $"StravaUserId: {StravaUserId}, \n" +
               $"Chain: {Chain}, \n" +
               $"Cassette: {Cassette}, \n" +
               $"FrontFork: {FrontFork}, \n" +
               $"RearShock: {RearShock}, \n" +
               $"ChainRing: {ChainRing}, \n" +
               $"BottomBracket: {BottomBracket}, \n" +
               $"Sealant: {Sealant}, \n" +
               $"BrakePads: {BrakePads}, \n" +
               $"BrakeRotors: {BrakeRotors}, \n" +
               $"Tires: {Tires}, \n" +
               $"Dropper: {Dropper}, \n" +
                "\n\n";
    }
}
