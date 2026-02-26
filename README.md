# Weather App

A weather application built with ASP.NET Core and C# that allows users to search for weather information and save their favorite cities.

## Features

- **Search Weather**: Search for any city and get real-time weather data (temperature, humidity, weather description)
- **Save Favorites**: Save favorite cities to a local database
- **View Favorites**: View all saved favorite cities
- **Delete Favorites**: Remove cities from your favorites list
- **Beautiful UI**: Clean and responsive user interface

## Technologies Used

- **Frontend**: HTML, CSS, JavaScript
- **Backend**: C# with ASP.NET Core (Razor Pages)
- **Database**: SQLite with Entity Framework
- **API**: OpenWeatherMap API for weather data

## Project Structure
```
Weather App/
├── Pages/
│   ├── Index.cshtml          # Frontend HTML/CSS/JavaScript
│   └── Index.cshtml.cs       # Backend C# code
├── Models/
│   └── FavoriteCity.cs       # Database model
├── Data/
│   └── WeatherContext.cs     # Database context
└── weather.db                # SQLite database
```

## How to Use

1. **Search for Weather**:
   - Enter a city name in the input field
   - Click "Search"
   - View the weather data (temperature, humidity, description)

2. **Save a City**:
   - After searching, click "Save to Favorites"
   - The city will be added to your favorites list

3. **View Favorites**:
   - Your saved favorite cities appear in the "Favorite Cities" section
   - Cities persist in the database even after closing the app

4. **Delete a Favorite**:
   - Click the "Delete" button next to any favorite city
   - The city will be removed from your favorites

## Key Concepts Demonstrated

- **Async/Await**: Non-blocking API calls using async/await pattern
- **HTTP Requests**: Calling external APIs (OpenWeatherMap)
- **Database Operations**: CRUD operations (Create, Read, Update, Delete)
- **Entity Framework**: ORM for database interactions
- **JavaScript Fetch API**: Communication between frontend and backend
- **JSON Parsing**: Handling JSON responses from APIs
- **Error Handling**: Try-catch blocks and proper error messages

## Installation & Setup

1. Clone the repository:
```bash
   git clone https://github.com/Vaibhav20777/Weather-App.git
```

2. Open the project in Visual Studio 2022

3. Get an API key from [OpenWeatherMap](https://openweathermap.org/api)

4. Replace the API key in `Index.cshtml.cs`:
```csharp
   string apiKey = "YOUR_API_KEY_HERE";
```

5. Run the application (F5)

## API Reference

This app uses the OpenWeatherMap API:
- **Endpoint**: `https://api.openweathermap.org/data/2.5/weather`
- **Parameters**: 
  - `q`: City name
  - `appid`: API key
  - `units=metric`: Temperature in Celsius

## Future Enhancements

- Add weather forecast (5-day forecast)
- Add weather icons
- Add temperature unit toggle (Celsius/Fahrenheit)
- Add wind speed and pressure information
- Deploy to cloud (Azure, Heroku)
- Add user authentication

## Learning Outcomes

Through building this project, I learned:
- ASP.NET Core Razor Pages
- Entity Framework Core for database management
- Async/await patterns for asynchronous programming
- Integration with external APIs
- Frontend-backend communication with fetch API
- CRUD operations with databases
- Error handling and validation

## Author

**Vaibhav** - [GitHub Profile](https://github.com/Vaibhav20777)

## License

This project is open source and available under the MIT License.

---

Feel free to fork this project and contribute!
