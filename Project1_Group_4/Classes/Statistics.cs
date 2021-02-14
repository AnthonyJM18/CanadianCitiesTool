using Project1_Group_4.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Project1_Group_4.Classes
{
    public class Statistics
    {
        private Dictionary<int, CityInfo> CityCatalogue;
        private string FilePath {get; set;}
        private eFileType FileType { get; set; }
        public delegate void PopulationHandler(object sender, EventArgs e);
        public event PopulationHandler PopulationChanged;

        public Statistics(string filePath)
        {
            // If filepath exists 
                
                // set file path

                // get file extension and set it

                // call the DataModeler parse file and store the reusting dictionary in the CityCatalogue dictionary

            // else throw exception
        }

        // City Methods
        public List<CityInfo> DisplayCityInformation(string city)
        {
            // convert city name to lowercase
            string cityLowerCase = city.ToLower();

            // create list of cityinfo to add if it has the same city name in CityCatalogue
            List<CityInfo> userCities = new List<CityInfo>();
            // Check if the dictionary has a record for the passed city name
            userCities = CityCatalogue.Values.Where(x => x.CityName == cityLowerCase).ToList();

            // if exists return the city
            if(userCities.Count > 0)
            {
                return userCities;
            }
            else
            {
                // if it does not exist return null
                return null;
            }
        }

        public CityInfo DisplayLargestPopulationCity()
        {
            // find the largest population city from the collection
            return CityCatalogue.Values.Aggregate((l, r) => l.Population > r.Population ? l : r);
        }

        public CityInfo DisplaySmallestPopulationCity()
        {
            // Find the lowest population city from the collection
            return CityCatalogue.Values.Aggregate((l, r) => l.Population < r.Population ? l : r);
        }

        public CityInfo CompareCitiesPopulation(CityInfo city1, CityInfo city2)
        {
            // Find which city has a larger population
            if(city1.Population > city2.Population)
            {
                return city1;
            }
            else
            {
                return city2;
            }
        }

        public string ShowCityOnMap(CityInfo city)
        {
            // First get lat and lng of the city
            return $"https://www.bing.com/maps?osid=518e8d2d-ea6e-494f-9f16-6835d4a19ea0&cp= {city.Latitude}~{city.Longitude}&lvl=14&style=h&v=2&sV=2&form=S00027";
        }
        public decimal CalculateDistanceBetweenCities(CityInfo city1, CityInfo city2)
        {
            // First get latlng of both cities
            // second we will attempt to use bing api to determine the distance between two cities
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins= {city1.Latitude},{city1.Longitude}&destinations={city2.Latitude},{city2.Longitude}&travelMode=driving&key=Askpq8KI6zxoBxJa7CrlZTJslLF1M03qjJVhrIhnIQm4zXTOQQQtad8irrRRBkCI").Result;
               
                if(response.IsSuccessStatusCode)
                {
                    HttpContent responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    JObject json = JObject.Parse(responseString);

                    decimal distance = (decimal)json.SelectToken("x.resourceSets[0].resources[0].results[0].travelDistance");

                    return distance;
                }

                throw new HttpRequestException();
            }
            
        }

        // Province Methods
        public int DisplayProvincePopulation(string province)
        {
            // search the collection for all cities with the specified province
            List<CityInfo> citiesOfProvince = CityCatalogue.Values.Where(c => c.Province == province).ToList();

            // add the population to a counter of some sort
            // return count
            return citiesOfProvince.Sum(c => c.Population);
        }

        public List<CityInfo> DisplayProvinceCities(string province)
        {
            // search the collection for all cities with the specified province
            return CityCatalogue.Values.Where(c => c.Province == province).ToList();
           
        }
        public List<KeyValuePair<string, int>> RankProvincesByPopulation()
        {
            // Get the population for every province

            // return a list of the province names, and populations
            return NotImplementedException;
        }
        public List<KeyValuePair<string, int>> RankProvincesByCities()
        {
            // get the number of cities for each province

            // return a list of province names, and the number of cities
            return NotImplementedException;
        }
        public CityInfo GetCapital(string province)
        {
            // Get the capital of the province

            // return it
            return NotImplementedException;
        }
        public string CityPopulationChangeEvent()
        {
            // maybe return a string about what change occured and let ui/client/user handle it

            return NotImplementedException;
        }
    }
}
