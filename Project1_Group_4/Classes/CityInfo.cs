﻿/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/20
 * 
 * Purpose:                     This class holds the the information of a city
 */

namespace Project1_Group_4.Classes
{
    public class CityInfo
    {
        public int CityID { get; private set; }
        public string CityName { get; private set; }
        public string CityAscii { get; private set; }
        public int Population { get; set; }
        public string Province { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }
        public bool IsCapital { get; private set; }

        public CityInfo() { }

        public CityInfo(int id, string name, string ascii, int pop, string prov, decimal lat, decimal lng, bool iscap)
        {
            CityID = id;
            CityName = name;
            CityAscii = ascii;
            Population = pop;
            Province = prov;
            Latitude = lat;
            Longitude = lng;
            IsCapital = iscap;
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

        public override string ToString()
        {
            return $"{CityName}, {Province}";
        }
    }
}
