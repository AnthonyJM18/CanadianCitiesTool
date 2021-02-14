using Project1_Group_4.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        }
        public Dictionary<int, CityInfo> ParseFile(string Filename, eFileType extension)
        {
            // create the delegate

            // switch on extension type to assign the correct method to the delegate

            // Maybe add a data cleaning method to delegate

            // call delegate and return the parsed data

            return NotImplementedException;
        }
    }
}
