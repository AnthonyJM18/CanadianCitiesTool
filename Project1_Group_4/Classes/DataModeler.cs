using System;
using System.Collections.Generic;
using System.Text;

namespace Project1_Group_4.Classes
{
    public class DataModeler
    {
        Dictionary<string, CityInfo> FileData;
        private delegate void SetupDataFile(string filename);

        private void ParseCSV(string filename)
        {

        }
        private void ParseJSON(string filename)
        {

        }
        private void ParseXML(string filename)
        {

        }
        public Dictionary<string, CityInfo> ParseFile(string Filename, eFileType extension)
        {
            // create the delegate

            // switch on extension type to assign the correct method to the delegate

            // Maybe add a data cleaning method to delegate

            // call delegate and return the parsed data

            return NotImplementedException;
        }
    }
}
