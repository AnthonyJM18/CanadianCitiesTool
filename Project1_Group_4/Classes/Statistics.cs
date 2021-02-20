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
        public Dictionary<int, CityInfo> CityCatalogue;
        private string FilePath {get; set;}
        private eFileType FileType { get; set; }
        public delegate void PopulationHandler(object sender, EventArgs e);

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

        public CityInfo DisplayLargestPopulationCity(string province)
        {
            // find the largest population city from the collection
            return CityCatalogue.Values.Where(c => c.Province == province).Aggregate((l, r) => l.Population > r.Population ? l : r);
        }

        public CityInfo DisplaySmallestPopulationCity(string province)
        {
            // Find the lowest population city from the collection
            return CityCatalogue.Values.Where(c => c.Province == province).Aggregate((l, r) => l.Population < r.Population ? l : r);
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
            return $"https://www.bing.com/maps?osid=1ef6d360-9e26-4037-a160-f8f8495a46db&cp={city.Latitude}~{city.Longitude}&lvl=11&style=h&v=2&sV=2&form=S00027";
        }
        public decimal CalculateDistanceBetweenCities(CityInfo city1, CityInfo city2)
        {
            // First get latlng of both cities
            // second we will attempt to use bing api to determine the distance between two cities
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

        public List<string> GetProvinces()
        {
            return (List<string>)CityCatalogue.Select(x => x.Value.Province).Distinct().ToList();
        }

        public List<Province> RankProvincesByPopulation(List<Province> provinces)
        {
            // Get the population for every province
             return provinces.OrderBy(p => p.Population).ToList();

        }
        public List<Province> RankProvincesByCities(List<Province> provinces)
        {
            // get the number of cities for each province
            return provinces.OrderBy(p => p.NumCities).ToList();
        }

        public CityInfo GetCapital(string province)
        {
            // Get the capital of the province
            return CityCatalogue.Values.SingleOrDefault(c => c.Province == province && c.IsCapital == true);
        }

        public string CityPopulationChangeEvent()
        {
            // maybe return a string about what change occured and let ui/client/user handle it
            return null;
        }
    }
}
