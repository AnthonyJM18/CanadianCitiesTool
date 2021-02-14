using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project1_Group_4.Classes
{
    public class Statistics
    {
        private Dictionary<string, CityInfo> CityCatalogue;
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
        public CityInfo DisplayCityInformation(string city)
        {
            // convert city name to lowercase

            // Check if the dictionary has a record for the passed city name
                
                // if exists return the city

            // if it does not exist return null
            return NotImplementedException;
        }

        public CityInfo DisplayLargestPopulationCity()
        {
            // find the largest population city from the collection

            // return it
            return NotImplementedException;
        }
        public CityInfo DisplaySmallestPopulationCity()
        {
            // Find the lowest population city from the collection

            // return it
            return NotImplementedException;
        }
        public CityInfo CompareCitiesPopulation(CityInfo city1, CityInfo city2)
        {
            // Find which city has a larger population

            // return the larger population city and the population number of each city
            return NotImplementedException;
        }
        public void ShowCityOnMap(CityInfo city)
        {
            // First get lat and lng of the city

            // create a url request or something 

            // open the url or process.start or something
            return NotImplementedException;
        }
        public decimal CalculateDistanceBetweenCities(CityInfo city1, CityInfo city2)
        {
            // First get latlng of both cities

            // second we will attempt to use googles api to determine the distance between two cities

            // in the event that it does not work, we will do the calculation by hand
            return NotImplementedException;
        }

        // Province Methods
        public int DisplayProvincePopulation(string province)
        {
            // search the collection for all cities with the specified province

                // add the population to a counter of some sort

            // return count
            return NotImplementedException;
        }
        public List<CityInfo> DisplayProvinceCities(string province)
        {
            // search the collection for all cities with the specified province

                // add it to a list

            // return the list of cities
            return NotImplementedException;
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
