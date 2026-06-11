// Calling HabitsDatabase.db

using System.Data;

var database = new Database();
database.CreateDatabase();

// start menu 
Console.WriteLine("Welcome to the Habit Logger!");
Console.WriteLine("Press one of the following options:\n1.Insert new log occurrence\n2.View logs\n3.Update logs\n4.Delete logs");
string choosenOption = Console.ReadLine();

switch (choosenOption)
{
    case "1":
        // Ask the user for input 
        Console.WriteLine($"You have choosen {choosenOption}: Insert new log occurrence!");
        Console.WriteLine("Insert the date");
        string date = Console.ReadLine();
        
        Console.WriteLine("Insert the quantity");
        int quantity = int.Parse(Console.ReadLine());
        
        // Insert into database
        database.InsertHabit(date, quantity);
        break;
    case "2":
        Console.WriteLine($"You have choosen {choosenOption}: View logs!");
        break;
    case "3":
        Console.WriteLine($"You have choosen {choosenOption}: Update logs!");
        break;
    case "4":
        Console.WriteLine($"You have choosen {choosenOption}!: Delete logs!");
        break;
}
