using System.Data.Entity;
using Weather_App.Models;




namespace Weather_App.Data
{
    public class WeatherContext:DbContext
    {
        public DbSet<FavoriteCity> FavoriteCities { get; set; }
        public WeatherContext() :base("Default Connection")
        {

        }
    }
}
