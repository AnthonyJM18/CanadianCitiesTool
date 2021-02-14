using System;
using System.Collections.Generic;
using System.Text;

namespace Project1_Group_4.Classes
{
    public class CityInfo
    {
        public string CityID { get; private set; }
        public string CityName { get; private set; }
        public string CityAscii { get; private set; }
        public int Population { get; set; }
        public string Province { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }

        public CityInfo() { }

        public CityInfo(string id, string name, string ascii, int pop, string prov, decimal lat, decimal lng)
        {
            CityID = id;
            CityName = name;
            CityAscii = ascii;
            Population = pop;
            Province = prov;
            Latitude = lat;
            Longitude = lng;
        }
        public string GetProvince()
        {
            // return province
            return Province;
        }

        public int GetPopulation()
        {
            // return population
            return Population;
        }

        public LatLng GetLocation()
        {
            //return Latitude + Longitude of city
            return new LatLng(Latitude, Longitude);
        }

    }
}
