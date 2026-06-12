## Habit Logger ##

**How the app works**

The habit logger is a console application that allows 
users to track the occurrences of a habit by quantity. 
When the app starts, it automatically creates a SQLite database and table
if they don't exist yet. Users can interact with the app trough a menu
with the following options:

- Insert a new habit occurence with a date and quantity
- View all logged habit occurrences
- Update an existing habit occurence
- Delete a habit occurence
- Exit the application

**Challenges**

The most challenging parts of this project were implementing the CRUD
operations correctly and applying the DRY principle. Debugging the database
interactions and making sure the right data was passed between `Program.cs` and 
`Database.cs` took some time. 

**What went well**

Building the start menu was relatively straightforward, as I had previous
experience with a similar menu structure from the Calculator Project. 

**What I learned**

- How to work with SQLite databases in C#
- How to use ADO.NET for database interactions
- CRUD operations (Create, Read, Update, Delete)
- the DRY principle and how to apply it
- Error handling (with try/catch)


