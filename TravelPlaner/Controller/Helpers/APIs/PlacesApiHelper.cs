using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Controller.Helpers.APIs.Exception;
using TravelPlaner.Model.Classes.PlacesAPI;
using TravelPlaner.Model.Classes.PlacesAPI.Autocomplete;
using TravelPlaner.Model.Classes.PlacesAPI.Sights;

namespace TravelPlaner.Controller.Helpers.APIs
{
    public class PlacesApiHelper
    {
        private const string API_KEY = "";
        private const string AUTOCOMPLETE_BASE_URL = "https://api.geoapify.com/v1/geocode/autocomplete?";
        private const string PLACES_BASE_URL = "https://api.geoapify.com/v2/places?";

        //Get Turist landmark list for display in program
        public async Task<List<TuristLandmark>> GetTuristLandmarksAsync(string cityName)
        {
            List<TuristLandmark> turistLandmarks = new List<TuristLandmark>();

            try
            {
                string placeId = await GetPlaceId(cityName);

                turistLandmarks = await GetTuristLandmarks(placeId);
            }
            catch(CityNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TurismSightsNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return turistLandmarks;
        }

        //Get TuristLandmarks list with API request
        private async Task<List<TuristLandmark>> GetTurismSightsAsync(string placeId)
        {
            List<TuristLandmark> landmarksNames = new List<TuristLandmark>();

            const string PLACE_URL = "categories=tourism.sights&filter=place:{0}&limit=5&apiKey={1}";
            string url = PLACES_BASE_URL + string.Format(PLACE_URL, placeId, API_KEY);

            //Get turist sights info for landmarks
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                SightsResponse? sightsResponse = JsonConvert.DeserializeObject<SightsResponse>(json);

                if (sightsResponse != null && sightsResponse.sights != null)
                {
                    foreach (var sight in sightsResponse.sights)
                    {
                        if (sight.properties != null && !string.IsNullOrEmpty(sight.properties.name))
                        {
                            TuristLandmark turistLandmark = new TuristLandmark();

                            turistLandmark.Name = sight.properties.name;
                            turistLandmark.Country = sight.properties.country;
                            turistLandmark.City = sight.properties.city;
                            turistLandmark.Street = sight.properties.street;
                            turistLandmark.Phone = sight.properties.contact.phone;

                            landmarksNames.Add(turistLandmark);
                        }
                    }
                }
                else { 
                    throw new TurismSightsNotFoundException();
                }
            }

            return landmarksNames;
        }

        //Get PlcaeId value for sights API request
        private async Task<string> GetPlaceIdAsync(string query)
        {
            string placeId = string.Empty;

            const string ID_URL = "text={0}&format=json&apiKey={1}";
            string url = AUTOCOMPLETE_BASE_URL + string.Format(ID_URL, query, API_KEY);

            //Get request for PlaceId
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                ApiResponse? apiResponse = JsonConvert.DeserializeObject<ApiResponse>(json);

                if (apiResponse != null && apiResponse.results != null && apiResponse.results.Count > 0)
                {
                    placeId = apiResponse.results[0].place_id;
                }

            }

            if (!string.IsNullOrEmpty(placeId))
            {
                return placeId;
            }

            throw new CityNotFoundException(query);
        }
    }
}
