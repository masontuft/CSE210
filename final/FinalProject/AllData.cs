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
            b.StravaBikeId = parts[12];
            b.StravaBikeName = parts[13];
            b.TotalMiles = int.Parse(parts[14]);
            b.StravaUserId = int.Parse(parts[15]);

            string filename2 = "part_service_periods.csv";
            var lines2 = File.ReadAllLines(filename2).Skip(1);
            foreach (string line2 in lines2)
            {
                string[] parts2 = line2.Split(',');
                if(b.StravaBikeId == parts[12])
                {
                    b.Chain = new Chain("Chain", int.Parse(parts[1]), int.Parse(parts2[1]));
                    b.Cassette = new Cassette("Cassette", int.Parse(parts[2]), int.Parse(parts2[2]));
                    b.FrontFork = new FrontFork("Front Fork", int.Parse(parts[3]), int.Parse(parts2[3]));
                    b.RearShock = new RearShock("Rear Shock", int.Parse(parts[4]), int.Parse(parts2[4]));
                    b.ChainRing = new ChainRing("Chain Ring", int.Parse(parts[5]), int.Parse(parts2[5]));
                    b.BottomBracket = new BottomBracket("Bottom Bracket", int.Parse(parts[6]), int.Parse(parts2[6]));
                    b.Sealant = new Sealant("Sealant", int.Parse(parts[7]), int.Parse(parts2[7]));
                    b.BrakePads = new BrakePads("Brake Pads", int.Parse(parts[9]), int.Parse(parts2[9]));
                    b.BrakeRotors = new BrakeRotors("Brake Rotors", int.Parse(parts[10]), int.Parse(parts2[10]));
                    b.Tires = new Tires("Tires", int.Parse(parts[11]), int.Parse(parts2[11]));
                    b.Dropper = new Dropper("Dropper", int.Parse(parts[16]), int.Parse(parts2[15]));
                }
            }
            
            BikesList.Add(b);
        }

        

        
    }
    public AllData()
    {
        BikesList = new List<Bike>();
    }

    public void ExportToTextFile(string filename, Shop shops)
    
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("------------------Bikes-------------------");
            foreach (Bike bike in BikesList)
            {
                
                writer.WriteLine(bike.GetBike());
            }
            writer.WriteLine("------------------Users-------------------");
            foreach (User user in User.UsersList)
            {
                
                writer.WriteLine(user.GetUser());
            }

            writer.WriteLine("------------------Shops-------------------");
            foreach (Shop shop in shops.ShopsList)
            {
                
                writer.WriteLine(shop.GetShop());
            }
        }
    }
}

    
