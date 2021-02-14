using System;
using System.Collections.Generic;
using System.Text;

namespace Project1_Group_4.Classes
{
    public class LatLng
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public LatLng(decimal lat, decimal lng)
        {
            Latitude = lat;
            Longitude = lng;
        }

        public override string ToString()
        {
            return $"{Latitude}, {Longitude}";
        }
    }
}
