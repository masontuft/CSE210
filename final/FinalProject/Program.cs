using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        AllData allData = new AllData("part_data.csv");
        Bike bike = new Bike();
        User user = new User("users.csv");
        Shop shops = new Shop("shops.csv");
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
                    Console.WriteLine("View a user's bikes");
                    int i = 1;
                    foreach (User currentUser in User.UsersList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"User number: {i}");
                        Console.WriteLine($"User: {currentUser.FirstName} {currentUser.LastName}, StravaUserId: {currentUser.StravaUserId}");
                        i++;
                    }
                    Console.WriteLine();
                    Console.Write("Enter the user number of the user you want to view: ");
                    int userIndex = int.Parse(Console.ReadLine());
                    Console.Clear();
                    bike.DisplayBikesByUserId(allData.BikesList, userIndex);
                    break;
                case "3":
                    Console.WriteLine("Display all bikes");
                    // AllData allBikes = new AllData("part_data.csv");
                    foreach(Bike currentBike in allData.BikesList)
                    {
                        currentBike.Display();
                    }
                    Console.WriteLine($"Just displayed {allData.BikesList.Count} bikes");
                    break;
                case "4":
                    Console.WriteLine("Display all parts on a bike");
                    bike.BikesMenu(allData.BikesList);
                    Console.Write("Enter the bike number of the bike you want to view: ");
                    int bikeIndex = int.Parse(Console.ReadLine());
                    Console.Clear();
                    bike.DisplayBikeByIndex(allData.BikesList, bikeIndex);
                    break;
                case "5":
                    Console.WriteLine("Display all users");
                    foreach (User currentUser in User.UsersList)
                    {
                        Console.WriteLine($"User: {currentUser.FirstName} {currentUser.LastName}\n StravaUserId: {currentUser.StravaUserId}");
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Just displayed {User.UsersList.Count} users");
                    break;
                case "6":
                    Console.WriteLine("View all shops");
                    foreach (Shop currentShop in shops.ShopsList)
                    {
                        currentShop.Display();
                        Console.WriteLine();
                    }
                    break;
                case "7":
                    Console.WriteLine("View a shop");
                    int j = 1;
                    foreach (Shop currentShop in shops.ShopsList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Shop number: {j}");
                        Console.WriteLine($"Shop: {currentShop.ShopName}");
                        j++;
                    }
                    Console.WriteLine("Enter the number of the shop you want to view: ");
                    int shopIndex = int.Parse(Console.ReadLine());
                    Console.Clear();
                    shopIndex--;
                    shops.DisplayShopByIndex(shops.ShopsList, shopIndex);
                    break;
                case "8":
                    Console.WriteLine("Export all Data into a text file");
                    break;
                case "9":
                    Console.WriteLine("Exit");
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
    public void Menu()
    {
        Console.WriteLine("1. View a bike");
        Console.WriteLine("2. View a user's bikes");
        Console.WriteLine("3. Display all bikes");
        Console.WriteLine("4. Display all parts on a bike");
        Console.WriteLine("5. Display all users");
        Console.WriteLine("6. View all shops");
        Console.WriteLine("7. View a shop");
        Console.WriteLine("8. Export all Data into a text file");
        Console.WriteLine("9. Exit");
    }
}