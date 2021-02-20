/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/20
 * Purpose:                     Statistics class for manipulating Dictionary<int, CityInfo> CityCatalogue. It also enables the user to retreieve all information
 *                              about the stored cities in the CityCatalogue. All input parameters are selected by the end-user of the application.
 */
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
        // Staistics Members
        public Dictionary<int, CityInfo> CityCatalogue;
        private string FilePath {get; set;}
        private eFileType FileType { get; set; }

        /// <summary>
        ///  The user must specify the file name, “Canadacities”, 
        ///  and then determine the file type or extension to be JSON, XML, or CSV.
        /// </summary>
        /// <param name="filePath"></param>
        public Statistics(string filePath)
        {
            // If filepath exists 
            if (File.Exists(filePath)) {
                // set file path
                FilePath = filePath;

                // get file extension and set it
                switch (filePath.Split('.')[2].ToUpper())
                {
                    case "CSV":
                        FileType = eFileType.CSV;
                        break;
                    case "XML":
                        FileType = eFileType.XML;
                        break;
                    case "JSON":
                        FileType = eFileType.JSON;
                        break;

                }

                // call the DataModeler parse file and store the reusting dictionary in the CityCatalogue dictionary
                DataModeler modeler = new DataModeler();
                CityCatalogue = modeler.ParseFile(FilePath, FileType);
            }
            // else throw exception
            else
            {
                throw new FileNotFoundException("The file " + filePath + " Could not be found");
            }
        }

        /// <summary>
        /// This method will take a CityName parameter and return all the city stored information in the CityCatalogue 
        /// dictionary variable.The application should show all cities sharing the
        /// same name or be creative and ask the user which city should be displayed
        /// </summary>
        /// <param name="city"></param>
        /// <returns>List of Cities</returns>
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

        /// <summary>
        /// It will return the largest population city in a province
        /// </summary>
        /// <param name="province"></param>
        /// <returns>CityInfo of largest pop city</returns>
        public CityInfo DisplayLargestPopulationCity(string province)
        {
            // find the largest population city from the collection
            return CityCatalogue.Values.Where(c => c.Province == province).Aggregate((l, r) => l.Population > r.Population ? l : r);
        }

        /// <summary>
        /// It will return the smallest population city in a province
        /// </summary>
        /// <param name="province"></param>
        /// <returns>CityInfo of smallest pop city</returns>
        public CityInfo DisplaySmallestPopulationCity(string province)
        {
            // Find the lowest population city from the collection
            return CityCatalogue.Values.Where(c => c.Province == province).Aggregate((l, r) => l.Population < r.Population ? l : r);
        }

        /// <summary>
        /// This method will take two parameters 
        /// each represents one city.It will return the city with a larger population
        /// and the population number of each city
        /// </summary>
        /// <param name="city1"></param>
        /// <param name="city2"></param>
        /// <returns>Cityinfo with the largest population compared</returns>
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

        /// <summary>
        /// Use the name of the city and province to mark a city on the map. Takes CityInfo's LatLng object.
        /// </summary>
        /// <param name="city"></param>
        /// <returns>URL of the map location on Bing</returns>
        public string ShowCityOnMap(CityInfo city)
        {
            // First get lat and lng of the city
            return $"https://www.bing.com/maps?osid=1ef6d360-9e26-4037-a160-f8f8495a46db&cp={city.Latitude}~{city.Longitude}&lvl=11&style=h&v=2&sV=2&form=S00027";
        }

        /// <summary>
        /// This method calculates the distance between any two cities using the latitude and longitude of 
        /// the input cities stored in the CityCatalogue dictionary variable.
        /// </summary>
        /// <param name="city1"></param>
        /// <param name="city2"></param>
        /// <returns>distance of the two places in decimal</returns>
        public decimal CalculateDistanceBetweenCities(CityInfo city1, CityInfo city2)
        {
            // First get latlng of both cities
            // second we will attempt to use bing api to determine the distance between two cities
            // if API does not work or returns -1, manually find distance
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    HttpResponseMessage response = client.GetAsync($"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins= {city1.Latitude},{city1.Longitude}&destinations={city2.Latitude},{city2.Longitude}&travelMode=driving&key=Askpq8KI6zxoBxJa7CrlZTJslLF1M03qjJVhrIhnIQm4zXTOQQQtad8irrRRBkCI").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        HttpContent responseContent = response.Content;
                        string responseString = responseContent.ReadAsStringAsync().Result;

                        JObject json = JObject.Parse(responseString);

                        decimal distance = (decimal)json.SelectToken("$.resourceSets[0].resources[0].results[0].travelDistance");

                        if (distance == -1)
                        {
                            return CalculateDistanceManual(city1, city2);
                        }

                        return distance;
                    }
                    else
                    {
                        return CalculateDistanceManual(city1, city2);
                    }
                }
            }
            catch (Exception)
            {
                return CalculateDistanceBetweenCities(city1, city2);
            }

        }

        /// <summary>
        /// Manually calculate distance using formulas
        /// </summary>
        /// <param name="city1"></param>
        /// <param name="city2"></param>
        /// <returns>Distance between two locations</returns>
        private decimal CalculateDistanceManual(CityInfo city1, CityInfo city2)
        {
            double rlat1 = Math.PI * (double)city1.Latitude / 180;
            double rlat2 = Math.PI * (double)city2.Latitude / 180;
            double theta = (double)city1.Longitude - (double)city2.Longitude;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return (decimal)Math.Round(dist * 1.609344, 3);
        }

        /// <summary>
        /// This method will take a province name parameter and return the sum of all populations of its cities saved in
        /// the CityCatalogue dictionary variable.
        /// </summary>
        /// <param name="province"></param>
        /// <returns>population of province as int</returns>
        public int DisplayProvincePopulation(string province)
        {
            // search the collection for all cities with the specified province
            List<CityInfo> citiesOfProvince = CityCatalogue.Values.Where(c => c.Province == province).ToList();

            // add the population to a counter of some sort
            // return count
            return citiesOfProvince.Sum(c => c.Population);
        }

        /// <summary>
        /// This method will take the province name  parameter and return a list of all cities of that province from the CityCatalogue dictionary variable
        /// </summary>
        /// <param name="province"></param>
        /// <returns>List of CityInfo of cities filtered by the selected province</returns>
        public List<CityInfo> DisplayProvinceCities(string province)
        {
            // search the collection for all cities with the specified province
            return CityCatalogue.Values.Where(c => c.Province == province).ToList();

        }

        /// <summary>
        /// This method will get all the provinces in CityCatalogue
        /// </summary>
        /// <param name="province"></param>
        /// <returns>List of String of Province Names</returns>
        public List<string> GetProvinces()
        {
            return CityCatalogue.Select(x => x.Value.Province).Distinct().ToList();
        }

        /// <summary>
        /// It will sort all provinces by population. 
        /// The order has to be ascending.The display should show the
        /// province and population number
        /// </summary>
        /// <param name="provinces"></param>
        /// <returns>List of Province sorted by pop</returns>
        public List<Province> RankProvincesByPopulation(List<Province> provinces)
        {
            // Get the population for every province
             return provinces.OrderBy(p => p.Population).ToList();

        }

        /// <summary>
        /// it will sort all provinces by the number of
        /// cities in each.The order has to be ascending.The display should
        /// show the province and number of included cities
        /// </summary>
        /// <param name="provinces"></param>
        /// <returns>List of Province sorted by numcities</returns>
        public List<Province> RankProvincesByCities(List<Province> provinces)
        {
            // get the number of cities for each province
            return provinces.OrderBy(p => p.NumCities).ToList();
        }

        /// <summary>
        /// It shows the capital of a province with its latitude and longitude
        /// </summary>
        /// <param name="province"></param>
        /// <returns>CityInfo of the capital of the selected province</returns>
        public CityInfo GetCapital(string province)
        {
            // Get the capital of the province
            return CityCatalogue.Values.SingleOrDefault(c => c.Province == province && c.IsCapital == true);
        }

    }
}
