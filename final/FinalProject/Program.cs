using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        AllData allData = new AllData("part_data.csv");
        Bike bike = new Bike();
        User user = new User("users.csv");
        bool finished = false;
        while (!finished)
        {
            Program program = new Program();
            program.Menu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("View a bike");
                    // allData.BikesList[0].Display();
                    bike.BikesMenu(allData.BikesList);
                    Console.Write("Enter the number of the bike you want to view: ");
                    int choice = int.Parse(Console.ReadLine());
                    // bike.FindBike(allData.BikesList[choice].StravaBikeId);
                    Console.Clear();
                    allData.BikesList[choice].Display();
                    break;
                case "2":
                    Console.WriteLine("Edit a part");
                    break;
                case "3":
                    Console.WriteLine("View a user");
                    break;
                case "4":
                    Console.WriteLine("Display all bikes");
                    // AllData allBikes = new AllData("part_data.csv");
                    foreach(Bike currentBike in allData.BikesList)
                    {
                        currentBike.Display();
                    }
                    Console.WriteLine($"Just displayed {allData.BikesList.Count} bikes");
                    break;
                case "5":
                    Console.WriteLine("Display all parts on a bike");
                    break;
                case "6":
                    Console.WriteLine("Display all users");
                    break;
                case "7":
                    Console.WriteLine("Export all Data into a text file");
                    break;
                case "8":
                    Console.WriteLine("Exit");
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        // Test creating a shop
        Shop shop = new Shop();
        Console.WriteLine($"Created shop with {shop.Bikes.Count} bikes");
        
        // Test creating a bike
        // Bike bike = new Bike();
        Console.WriteLine("Created a bike");
        
        // Test adding the bike to the shop
        shop.Bikes.Add(bike);
        Console.WriteLine($"Shop now has {shop.Bikes.Count} bikes");
        
        // Test AllData class
        // allData.BikesList.Add(bike);
        Console.WriteLine($"AllData has {allData.BikesList.Count} bikes");
        
        // Test creating a Part
        Part part = new Part();
        Console.WriteLine("Created a part");
        
        // Test creating a User
        
        Console.WriteLine("Created a user");
        
        Console.WriteLine("All tests completed successfully");
    }
    public void Menu()
    {
        Console.WriteLine("1. View a bike");
        Console.WriteLine("2. Add a part");
        Console.WriteLine("3. Add a user");
        Console.WriteLine("4. Display all bikes");
        Console.WriteLine("5. Display all parts on a bike");
        Console.WriteLine("6. Display all users");
        Console.WriteLine("7. Export all Data into a text file");
        Console.WriteLine("8. Exit");
    }
}