class AllData
{
    public List<Bike> BikesList;
    
    public AllData(string filename)
    {
        BikesList = new List<Bike>();
        var lines = File.ReadAllLines(filename).Skip(1);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Bike b = new Bike();
            b.Id = int.Parse(parts[0]);
            b.ChainUsedMiles = int.Parse(parts[1]);
            b.CassetteUsedMiles = int.Parse(parts[2]);
            b.FrontForkUsedMiles = int.Parse(parts[3]);
            b.RearShockUsedMiles = int.Parse(parts[4]);
            b.ChainRingUsedMiles = int.Parse(parts[5]);
            b.BottomBracketUsedMiles = int.Parse(parts[6]);
            b.SealantUsedHours = int.Parse(parts[7]);
            b.BrakePadsUsedMiles = int.Parse(parts[9]);
            b.BrakeRotorsUsedMiles = int.Parse(parts[10]);
            b.TiresUsedMiles = int.Parse(parts[11]);
            b.StravaBikeId = parts[12];
            b.StravaBikeName = parts[13];
            b.TotalMiles = int.Parse(parts[14]);
            b.StravaUserId = int.Parse(parts[15]);
            b.DropperUsedMiles = int.Parse(parts[16]);
            BikesList.Add(b);
            // Console.WriteLine(b);
            // b.Display();

            // Id = int.Parse(values[0]),
            // ChainUsedMiles = int.Parse(values[1]),
            // CassetteUsedMiles = int.Parse(values[2]),
            // FrontForkUsedMiles = int.Parse(values[3]),
            // RearShockUsedMiles = int.Parse(values[4]),
            // ChainRingUsedMiles = int.Parse(values[5]),
            // BottomBracketUsedMiles = int.Parse(values[6]),
            // SealantUsedHours = int.Parse(values[7]),
            // BrakeBleedDate = values[8],
            // BrakePadsUsedMiles = int.Parse(values[9]),
            // BrakeRotorsUsedMiles = int.Parse(values[10]),
            // TiresUsedMiles = int.Parse(values[11]),
            // StravaBikeId = values[12],
            // StravaBikeName = values[13],
            // TotalMiles = int.Parse(values[14]),
            // StravaUserId = int.Parse(values[15]),
            // DropperUsedMiles = int.Parse(values[16])
        }
        
    }
    public AllData()
    {
        BikesList = new List<Bike>();
    }
}

    
