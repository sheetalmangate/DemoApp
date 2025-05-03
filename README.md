# DemoApp

DemoApp is a Razor Pages web application built with .NET 9. It provides a simple structure for user registration, login, and secure page access. The project uses Bootstrap for styling and follows modern web development practices.

## Features

- User registration and login functionality
- Secure pages accessible only to authenticated users
- Responsive design using Bootstrap
- Modular Razor Pages layout with reusable components
- Entity Framework Core for database interactions

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Database : PostgreSql 

## Getting Started

### 1. Clone the Repository

git clone git@github.com:sheetalmangate/DemoApp.git

### 2. Configure the Database

Update the `appsettings.json` file with your database connection string:


### 3. Apply Migrations

Run the following commands to create the database and apply migrations:

dotnet ef database update


### 4. Run the Application

Start the application using the .NET CLI or Visual Studio 2022:

dotnet run


Alternatively, open the project in Visual Studio and press __F5__ to run.

### 5. Access the Application

Navigate to `https://localhost:5125` in your browser.

## Project Structure

- **Controllers**: Handles HTTP requests and responses.
- **Models**: Contains the data models and view models.
- **Views**: Razor Pages for the UI.
- **Entities**: Database entities and `DbContext`.
- **wwwroot**: Static files like CSS, JavaScript, and images.

## Key Files

- `Views/Shared/_Layout.cshtml`: Defines the main layout of the application.
- `Views/Shared/_LoginPartial.cshtml`: Partial view for login/logout functionality.
- `appsettings.json`: Configuration file for the application.
- `Program.cs`: Entry point of the application.

## Technologies Used

- .NET 9
- Razor Pages
- Entity Framework Core
- Bootstrap 5

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
