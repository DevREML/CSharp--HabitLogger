// Calling HabitsDatabase.db
var database = new Database();
database.CreateDatabase();

// start menu 
Console.WriteLine("Welcome to the Habit Logger!");
Console.WriteLine("Press one of the following options:\n1.Insert new habit\n2.View habits\n3.Update habits\n4.Delete habits");
string choosenOption = Console.ReadLine();

switch (choosenOption)
{
    case "1":
        Console.WriteLine($"You have choosen {choosenOption}!");
        break;
    case "2":
        Console.WriteLine($"You have choosen {choosenOption}!");
        break;
    case "3":
        Console.WriteLine($"You have choosen {choosenOption}!");
        break;
    case "4":
        Console.WriteLine($"You have choosen {choosenOption}!");
        break;
}
