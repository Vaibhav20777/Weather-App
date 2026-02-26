using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Weather_App.Data;
using Weather_App.Models;

namespace Weather_App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public JsonResult OnGetSaveFavoriteAsync(string cityname, string country)
    {
        try
        {
            using (var context = new WeatherContext())
            {
                var favourite = new FavoriteCity
                {
                    CityName = cityname,
                    Country = country,
                    SavedDate = DateTime.Now,
                };
                context.FavoriteCities.Add(favourite);
                context.SaveChanges();
                return new JsonResult(new { success = true, message = "City Saved" });
            }
        }
        catch
        {
            return new JsonResult(new { success = false, message = "Error Saving City" });

        }
    }
    public JsonResult OnGetGetFavoritesAsync()
    {
        try
        {
            using(var context = new WeatherContext())
            {
                var favorites = context.FavoriteCities.ToList();
                return new JsonResult(favorites);

            }
        }
        catch
        {
            return new JsonResult(new { success = false, message = "Error fetching favorite cities" });
        }
    }
    public JsonResult OnGetDeleteFavoriteAsync(int id)
    {
        try
        {
            using (var context = new WeatherContext())
            {
                var favorite = context.FavoriteCities.FirstOrDefault(f => f.Id == id);
                if (favorite != null)
                {
                    context.FavoriteCities.Remove(favorite);
                    context.SaveChanges();
                    return new JsonResult(new { success = true, message = "City has been deleted" });
                }
                return new JsonResult(new { success = false, message = "City not found" });
            }
        }
        catch
        {
            return new JsonResult(new { success = false, message = "Error finding city" });
        }
    }


    public async Task<IActionResult> OnGetWeatherAsync(string city)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiKey = "6bde0654ad0f5edeedf897f5a55c5731";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string result = await response.Content.ReadAsStringAsync();
                return new ContentResult
                {
                    Content = result,
                    ContentType = "application/json"
                };
            }
            catch
            {
                return new JsonResult(new { error = "Error Fetching Weather" });
            }
        }
    }
}
