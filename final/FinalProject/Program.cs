using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        // Test creating a shop
        Shop shop = new Shop();
        Console.WriteLine($"Created shop with {shop.Bikes.Count} bikes");
        
        // Test creating a bike
        Bike bike = new Bike();
        Console.WriteLine("Created a bike");
        
        // Test adding the bike to the shop
        shop.Bikes.Add(bike);
        Console.WriteLine($"Shop now has {shop.Bikes.Count} bikes");
        
        // Test AllData class
        AllData allData = new AllData("part_data.csv");
        allData.BikesList.Add(bike);
        Console.WriteLine($"AllData has {allData.BikesList.Count} bikes");
        
        // Test creating a Part
        Part part = new Part();
        Console.WriteLine("Created a part");
        
        // Test creating a User
        User user = new User();
        Console.WriteLine("Created a user");
        
        Console.WriteLine("All tests completed successfully");
    }
}