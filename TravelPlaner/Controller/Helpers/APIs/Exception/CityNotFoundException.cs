

namespace TravelPlaner.Controller.Helpers.APIs.Exception
{
    public class CityNotFoundException : System.Exception
    {
        // Default constructor
        public CityNotFoundException(string cityName): base($"City:{cityName} not found.")
        {
        }
    }
}
