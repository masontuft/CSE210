public class AllData
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
            string filename2 = "part_service_periods.csv";
            var lines2 = File.ReadAllLines(filename2).Skip(1);
            foreach (string line2 in lines2)
            {
                string[] parts2 = line2.Split(',');
                if(b.StravaBikeId == parts[12])
                {
                    b.ChainMiles = int.Parse(parts2[1]);
                    b.CassetteMiles = int.Parse(parts2[2]);
                    b.FrontForkMiles = int.Parse(parts2[3]);
                    b.RearShockMiles = int.Parse(parts2[4]);
                    b.ChainRingMiles = int.Parse(parts2[5]);
                    b.BottomBracketMiles = int.Parse(parts2[6]);
                    b.SealantRefreshHours = int.Parse(parts2[7]);
                    // b.BrakeBleedMiles = int.Parse(parts2[8]);
                    b.BrakePadsMiles = int.Parse(parts2[9]);
                    b.BrakeRotorsMiles = int.Parse(parts2[10]);
                    b.TiresMiles = int.Parse(parts2[11]);
                    // Chain type
                    // Cassette type
                    b.DropperMiles = int.Parse(parts2[15]);
                }
            }
            BikesList.Add(b);
        }

        

        
    }
    public AllData()
    {
        BikesList = new List<Bike>();
    }
}

    
