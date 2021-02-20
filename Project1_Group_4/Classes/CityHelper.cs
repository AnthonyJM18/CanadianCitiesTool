/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/20
 * 
 * Purpose:                     Helper class to get city information for json serializer
 */

namespace Project1_Group_4.Classes
{
    class CityHelper
    {
        public string city { get; set; }
        public string city_ascii { get; set; }
        public decimal lat { get; set; }
        public decimal lng { get; set; }
        public string country { get; set; }
        public string admin_name { get; set; }
        public string capital { get; set; }
        public int population { get; set; }
        public int id { get; set; }
    }
}
