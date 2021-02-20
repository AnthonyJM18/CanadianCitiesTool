/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/14
 * 
 * Purpose:                     This is the forms class that displays and manages all initialization and events for Province Window.cs
 */

using Project1_Group_4.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1_Group_4.Forms
{
    public partial class ProvinceWindow : Form
    {
        // data members
        readonly Statistics stats;
        readonly List<Province> provinces;

        /// <summary>
        /// Constructor for the provicne window and init fields
        /// </summary>
        /// <param name="stat"></param>
        /// <param name="provs"></param>
        public ProvinceWindow(Statistics stat, List<Province> provs)
        {
            InitializeComponent();
            stats = stat;
            provinces = provs;
        }

        /// <summary>
        /// Onclick handler to sort the provinces by number of cities (ascending)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SortCityAsec_Click(object sender, EventArgs e)
        {
            var provincesByCityAcec = stats.RankProvincesByCities(provinces);
            this.listBox_Provinces.Items.Clear();

            foreach (var item in provincesByCityAcec)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.NumCities}");
            }
        }

        /// <summary>
        /// Onclick handler to sort the provinces by number of cities (descending)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SortCityDesc_Click(object sender, EventArgs e)
        {
            var provincesByCityDesc = stats.RankProvincesByCities(provinces);
            provincesByCityDesc.Reverse();
            this.listBox_Provinces.Items.Clear();
            foreach (var item in provincesByCityDesc)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.NumCities}");
            }
        }

        /// <summary>
        /// Onclick handler to sort the provinces by population (ascending)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SortPopAsec_Click(object sender, EventArgs e)
        {
            var provincesByPopAcec = stats.RankProvincesByPopulation(provinces);
            this.listBox_Provinces.Items.Clear();

            foreach (var item in provincesByPopAcec)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.Population}");
            }
        }

        /// <summary>
        /// Onclick handler to sort the provinces by population (descending)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_SortPopDesc_Click(object sender, EventArgs e)
        {
            var provincesByPopDesc = stats.RankProvincesByPopulation(provinces);
            provincesByPopDesc.Reverse();
            this.listBox_Provinces.Items.Clear();

            foreach (var item in provincesByPopDesc)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.Population}");
            }
        }
    }
}
