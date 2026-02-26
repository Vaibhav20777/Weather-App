namespace Weather_App.Models
{
    public class FavoriteCity
    {
        public int Id {  get; set; }
        public string CityName { get; set; }
        public string Country {  get; set; }
        public DateTime SavedDate { get; set; }
    }
}
