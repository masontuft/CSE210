public class Bike : AllData
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
        Console.WriteLine();
        Console.WriteLine("Strava Bike Name: " + StravaBikeName);
        Console.WriteLine();
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Strava Bike ID: " + StravaBikeId);
        Console.WriteLine("Strava User ID: " + StravaUserId);
        Console.WriteLine("Chain Used Miles: " + ChainUsedMiles);
        Console.WriteLine("Chain Miles: " + ChainMiles);
        Console.WriteLine("Cassette Used Miles: " + CassetteUsedMiles);
        Console.WriteLine("Cassette Miles: " + CassetteMiles);
        Console.WriteLine("Front Fork Used Miles: " + FrontForkUsedMiles);
        Console.WriteLine("Front Fork Miles: " + FrontForkMiles);
        Console.WriteLine("Rear Shock Used Miles: " + RearShockUsedMiles);
        Console.WriteLine("Rear Shock Miles: " + RearShockMiles);
        Console.WriteLine("Chain Ring Used Miles: " + ChainRingUsedMiles);
        Console.WriteLine("Chain Ring Miles: " + ChainRingMiles);
        Console.WriteLine("Bottom Bracket Used Miles: " + BottomBracketUsedMiles);
        Console.WriteLine("Bottom Bracket Miles: " + BottomBracketMiles);
        Console.WriteLine("Sealant Used Hours: " + SealantUsedHours);
        Console.WriteLine("Sealant Refresh Hours: " + SealantRefreshHours);
        Console.WriteLine("Brake Pads Used Miles: " + BrakePadsUsedMiles);
        Console.WriteLine("Brake Pads Miles: " + BrakePadsMiles);
        Console.WriteLine("Brake Rotors Used Miles: " + BrakeRotorsUsedMiles);
        Console.WriteLine("Brake Rotors Miles: " + BrakeRotorsMiles);
        Console.WriteLine("Tires Used Miles: " + TiresUsedMiles);
        Console.WriteLine("Tires Miles: " + TiresMiles);
        Console.WriteLine("Dropper Used Miles: " + DropperUsedMiles);
        Console.WriteLine("Dropper Miles: " + DropperMiles);
        Console.WriteLine("Total Miles: " + TotalMiles);
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
                Console.WriteLine(); // Add space between bikes
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
            // BikesList[index].Display();
            StravaBikeId = bikes[index].StravaBikeId;
            StravaBikeName = bikes[index].StravaBikeName;
            StravaUserId = bikes[index].StravaUserId;
            ChainUsedMiles = bikes[index].ChainUsedMiles;
            CassetteUsedMiles = bikes[index].CassetteUsedMiles;
            FrontForkUsedMiles = bikes[index].FrontForkUsedMiles;
            RearShockUsedMiles = bikes[index].RearShockUsedMiles;
            ChainRingUsedMiles = bikes[index].ChainRingUsedMiles;
            BottomBracketUsedMiles = bikes[index].BottomBracketUsedMiles;
            SealantUsedHours = bikes[index].SealantUsedHours;
            BrakePadsUsedMiles = bikes[index].BrakePadsUsedMiles;
            BrakeRotorsUsedMiles = bikes[index].BrakeRotorsUsedMiles;
            TiresUsedMiles = bikes[index].TiresUsedMiles;
            TotalMiles = bikes[index].TotalMiles;
            DropperUsedMiles = bikes[index].DropperUsedMiles;
            Display();
        }
        else
        {
            Console.WriteLine("Invalid bike index.");
        }
        
    }
}
