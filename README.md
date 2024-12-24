# SimpleCosmos

SimpleCosmos is a .NET 8 console application that demonstrates how to use Azure Cosmos DB with Entity Framework Core. The application allows users to create blogs with posts and associated cars through a terminal interface.

## Features

- Create multiple blogs with posts and cars through a terminal interface.
- Store data in Azure Cosmos DB using Entity Framework Core.
- Use dependency injection and configuration management.

## Prerequisites

- .NET 8 SDK
- Azure Cosmos DB account

## Getting Started

### Clone the Repository

### Configuration

 Create an `appsettings.json` file in the project root with ->
 "cosmosdb": {add your cosmos db account and key here} 
1. "endpoint": "https://your-cosmos-db-account.documents.azure.com:443/",
2. "key": "your-cosmos-db-key", 
2. "database": "db-name"

 Update the `endpoint`, `key`, and `database` values with your Azure Cosmos DB account details.
 
### Build and Run

- dotnet build 
- dotnet run




## Usage

When you run the application, you will be prompted to enter details for creating blogs, posts, and cars. The application will loop until you type `exit` to quit.

### Example Interaction
Enter blog name (or type 'exit' to quit): My Blog 
Enter blog description: My Car blog 
Enter post title: My First Post 
Enter car name (or type 'done' to finish adding cars): Car 1 
Enter car name (or type 'done' to finish adding cars): Car 2 
Enter car name (or type 'done' to finish adding cars): done 

Blog added successfully!


## Project Structure

SimpleCosmos/
├── src/  <-- New folder for source code
│   ├── Data/
│   │   └── DbContext.cs  <-- Data access logic
│   ├── Models/
│   │   ├── Blog.cs  <-- Domain entity representations
│   │   ├── Car.cs   <-- (Optional) If Car is related to Blog or Post
│   │   └── Post.cs
│   ├── Services/  <-- Folder for business logic services
│   │   └── BlogService.cs  <-- (Optional) Service for Blog-related operations
│   └── ViewModels/  <-- New folder for view models (if applicable)
│       └── UserInteraction.cs  <-- View model for user interaction
├── appsettings.json  <-- Configuration settings
├── Program.cs        <-- Application entry point
├── SimpleCosmos.csproj  <-- Project file
└── README.md         <-- Project documentation

### Description

- **Data/DbContext.cs**: Contains the `BlogContext` class for Entity Framework Core configuration and Cosmos DB setup.
- **Models/**: Contains the data models `Blog`, `Post`, and `Car`.
- **Service/BlogService.cs**: Contains the `BlogService` class for handling business logic related to blogs, posts, and cars.
- **View/UserInteraction.cs**: Contains the `UserInteraction` class for handling user input through the terminal.
- **Program.cs**: The main entry point of the application, sets up dependency injection and starts the user interaction loop.
- **appsettings.json**: Configuration file for Cosmos DB connection settings.
- **SimpleCosmos.csproj**: Project file containing dependencies and build configuration.

## Dependencies

- Microsoft.EntityFrameworkCore.Cosmos
- Microsoft.Extensions.Configuration
- Microsoft.Extensions.Hosting

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## Contact

For any questions or inquiries, please contact [your-email@example.com].