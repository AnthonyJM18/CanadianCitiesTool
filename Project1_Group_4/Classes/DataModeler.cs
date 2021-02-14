using Project1_Group_4.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Project1_Group_4.Classes
{
    public class DataModeler
    {
        Dictionary<int, CityInfo> FileData;
        private delegate void SetupDataFile(string filename);

        private void ParseCSV(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                reader.ReadLine();
                var file = reader.ReadToEnd();
                var lines = file.Split('\n');

                foreach (var line in lines)
                {
                    var cityInfo = line.Split(',');

                    CityInfo city = new CityInfo(int.Parse(cityInfo[8]), cityInfo[1], cityInfo[2], int.Parse(cityInfo[7]), cityInfo[5],
                        decimal.Parse(cityInfo[2]), decimal.Parse(cityInfo[3]), cityInfo[6] == "admin");

                    FileData.Add(city.CityID, city);
                }
            }
        }
        private void ParseJSON(string filename)
        {

        }
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
                CityInfo city = new CityInfo(id, name, ascii, population, province, lat, lng, iscap);

                FileData.Add(city.CityID, city);
            }
        }
        public Dictionary<int, CityInfo> ParseFile(string Filename, eFileType extension)
        {
            // create the delegate

            // switch on extension type to assign the correct method to the delegate

            // Maybe add a data cleaning method to delegate

            // call delegate and return the parsed data

            return FileData;
        }
    }
}
