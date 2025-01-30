using Azure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Controller.Helpers.APIs.Exception;
using TravelPlaner.Model.Classes.CnCAPI;

namespace TravelPlaner.Controller.Helpers.APIs
{
    public class CncApiHelper
    {
        private const string API_BASE_URL = "https://countriesnow.space/api/v0.1/countries";
        private List<Datum> cachedData;

        public CncApiHelper()
        {
            cachedData = new List<Datum>();
        }

        public async Task<List<string>> GetCountriesAsync()
        {
            try
            {
                if (!cachedData.Any())
                {
                    await FetchAndCacheData();
                }

                return cachedData.Select(d => d.country).ToList();
            }
            catch (CountryNotFoundException ex)
            {
                Console.WriteLine($"Error fetching countries: {ex.Message}");
                return new List<string>();
            }
        }

        public async Task<List<string>> GetCitiesForCountryAsync(string countryName)
        {
            try
            {
                if (!cachedData.Any())
                {
                    await FetchAndCacheData();
                }

                var country = cachedData.FirstOrDefault(d =>
                    d.country.Equals(countryName, StringComparison.OrdinalIgnoreCase));

                if (country == null)
                {
                    throw new CountryNotFoundException(countryName);
                }

                return country.cities.ToList();
            }
            catch (CountryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
            catch (ApiDataNotFoundException ex)
            {
                Console.WriteLine($"Error fetching cities: {ex.Message}");
                return new List<string>();
            }
        }

        private async Task FetchAndCacheData()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(API_BASE_URL);
                string json = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<Example>(json);

                if (apiResponse != null && apiResponse.data != null)
                {
                    cachedData = apiResponse.data.ToList();
                }
                else
                {
                    throw new ApiDataNotFoundException();
                }
            }
        }

    }
    public class CountryNotFoundException : System.Exception
    {
        public CountryNotFoundException(string countryName)
            : base($"Country '{countryName}' not found.") { }
    }

    public class ApiDataNotFoundException : System.Exception
    {
        public ApiDataNotFoundException()
            : base("Failed to fetch data from the API.") { }
    }
}
