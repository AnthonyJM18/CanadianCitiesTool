/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/20
 * 
 * Purpose:                     Helper class for a cities location of latitude and longitude
 */

using System;

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

        /// <summary>
        /// overrides ToSting method to return latitude and longitude
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Math.Round(Latitude,4)}, {Math.Round(Longitude, 4)}";
        }
    }
}
