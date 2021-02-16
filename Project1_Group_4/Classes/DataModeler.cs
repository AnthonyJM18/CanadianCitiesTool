/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/14
 * 
 * Purpose:                     This class holds the methods to parse the data files and add to the dictionary using a delegate
 */

using Project1_Group_4.Enums;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace Project1_Group_4.Classes
{
    public class DataModeler
    {
        Dictionary<int, CityInfo> FileData;
        private delegate void SetupDataFile(string filename);

        /// <summary>
        /// Reads csv file, parses the data in a CityInfo object and adds it to a dictionary of an int id and CityInfo object
        /// </summary>
        /// <param name="filename"></param>
        private void ParseCSV(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                reader.ReadLine();
                var file = reader.ReadToEnd().Trim();

                //parse data
                var lines = file.Split('\n');

                // create city object and add to dictionary
                foreach (var line in lines)
                {
                    var cityInfo = line.Split(',');

                    CityInfo city = new CityInfo(int.Parse(cityInfo[8]), cityInfo[0], cityInfo[1], int.Parse(cityInfo[7]), cityInfo[5],
                        decimal.Parse(cityInfo[2]), decimal.Parse(cityInfo[3]), cityInfo[6] == "admin");

                    FileData.Add(city.CityID, city);
                }
            }
        }
        /// <summary>
        /// Reads JSON file, parses the data in a CityInfo object and adds it to a dictionary of an int id and CityInfo object
        /// </summary>
        /// <param name="filename"></param>
        private void ParseJSON(string filename)
        {
            string json = File.ReadAllText(filename);

            // parse data
            List<CityHelper> cities = JsonConvert.DeserializeObject<List<CityHelper>>(json);

            // create city object and add to dictionary
            foreach (CityHelper city in cities)
            {
                bool capital = city.capital == "admin";
                CityInfo cityInfo = new CityInfo(city.id,city.city, city.city_ascii, city.population, city.admin_name, city.lat, city.lng, capital);
                if (string.IsNullOrEmpty(cityInfo.CityName)) // handles last entry in json
                {
                    FileData.Add(cityInfo.CityID, cityInfo);
                }
            }
        }
        /// <summary>
        /// Reads XML file, parses the data in a CityInfo object and adds it to a dictionary of an int id and CityInfo object
        /// </summary>
        /// <param name="filename"></param>
        private void ParseXML(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            //get node list of canadian cities
            XmlNode root = doc.DocumentElement;
            XmlElement rootElement = (XmlElement)root;
            XmlNodeList cities = rootElement.SelectNodes("//CanadaCity");

            foreach (XmlNode n in cities)
            {
                // variables to match cityinfo data
                int id = 0;
                string name = "";
                string ascii = "";
                int population = 0;
                string province = "";
                decimal lat = 0;
                decimal lng = 0;
                bool iscap = false;

                foreach (XmlNode child in n.ChildNodes)
                {
                    // change variables to matching switch case
                    string childName = child.Name;
                    switch (childName)
                    {
                        case "city":
                            {
                                name = child.InnerText;
                                break;
                            }
                        case "city_ascii":
                            {
                                ascii = child.InnerText;
                                break;
                            }
                        case "lat":
                            {
                                lat = decimal.Parse(child.InnerText);
                                break;
                            }
                        case "lng":
                            {
                                lng = decimal.Parse(child.InnerText);
                                break;
                            }
                        case "admin_name":
                            {
                                province = child.InnerText;
                                break;
                            }
                        case "capital":
                            {
                                string capital = child.InnerText;
                                iscap = capital == "admin" ? true : false;
                                break;
                            }
                        case "population":
                            {
                                population = int.Parse(child.InnerText);
                                break;
                            }
                        case "id":
                            {
                                id = int.Parse(child.InnerText);
                                break;
                            }
                    }
                }
                // create CityInfo object and add to dictionary
                CityInfo city = new CityInfo(id, name, ascii, population, province, lat, lng, iscap);

                FileData.Add(city.CityID, city);
            }
        }
        /// <summary>
        /// Initialize dictionary object, then depending on efile type, initialize delegate and to load data in dictionary and return dictionary
        /// </summary>
        /// <param name="Filename"></param>
        /// <param name="extension"></param>
        /// <returns>Dictonary<int, CityInfo></int></returns>
        public Dictionary<int, CityInfo> ParseFile(string Filename, eFileType extension)
        {
            // clean FileData dictionary
            FileData = new Dictionary<int, CityInfo>();

            // create the delegate
            SetupDataFile setupData = null;

            // switch on extension type to assign the correct method to the delegate
            switch (extension)
            {
                case eFileType.CSV:
                    {
                        setupData = ParseCSV;
                        break;
                    }
                case eFileType.JSON:
                    {
                        setupData = ParseJSON;
                        break;
                    }
                case eFileType.XML:
                    {
                        setupData = ParseXML;
                        break;
                    }
            }

            // call delegate and return the parsed data
            setupData(Filename);

            return FileData;
        }
    }
}
