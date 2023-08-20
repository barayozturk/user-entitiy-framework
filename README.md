# .NET Web API for Managing User Data 🌐

In this project, we focus on managing "User" data using .NET Web API. We created the User model, learned to store this data in a database using Entity Framework Core, and documented the API using Swagger/OpenAPI. Let's dive into the codes step by step.

## Database Model 📂

The User model holds basic properties for user information:

```csharp
namespace WebApplicationTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
```
##Project Structure 🏗️
The project's file structure is as follows:

- Controllers/     # API controller codes
- Data/            # Database connection and Entity Framework codes
- Models/          # Database models
- appsettings.json # Application settings
- Program.cs       # Application entry point and configuration
- Startup.cs       # Application configuration settings


##Entity Framework Migrations 🔄
Entity Framework migrations are used to update the database. Steps to create migrations:

Open the terminal and navigate to the project folder.

Execute the following commands:
````
dotnet tool install --global dotnet-ef # If not installed previously
dotnet ef migrations add InitialCreate
dotnet ef database update
````

##Swagger Documentation 📖
Swagger/OpenAPI is used to automatically generate and visualize API documentation.

Swagger documentation steps:

In Startup.cs, add the following code to the ConfigureServices method:

````
services.AddSwaggerGen();
app.UseSwagger();
app.UseSwaggerUI();
````

##API Controller 🛠️
We created a controller to handle API requests. For instance, 


##Running the Application ▶️
To run the application:

Open the terminal and navigate to the project folder.
Run the dotnet run command.
In your browser, visit https://localhost:5001/swagger to view Swagger documentation.



##Conclusion 🎉
This project is a great resource to learn about creating a .NET Web API, managing database models, applying migrations, creating API controllers, and documenting the API using Swagger. This README file will help you understand the project step by step! 🚀
