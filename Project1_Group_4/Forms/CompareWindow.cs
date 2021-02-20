/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/14
 * 
 * Purpose:                     This is the forms class that displays and manages all initialization and events for CompareWindow.cs
 */

using Project1_Group_4.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1_Group_4.Forms
{
    public partial class CompareWindow : Form
    {
        // init stats class
        private readonly Statistics statistics;
        // Constructor for compare window 
        public CompareWindow(CityInfo selectedCity, List<CityInfo> items, Statistics stats)
        {
            // Winforms init method
            InitializeComponent();
            // assign statistics 
            this.statistics = stats;
            // add the city items to both comboboxes
            foreach (var item in items)
            {
                this.comboBox_city1.Items.Add(item);
                this.comboBox_city2.Items.Add(item);
            }
            // if applicable set the selected item
            this.comboBox_city1.SelectedItem = selectedCity;
        }

        /// <summary>
        /// IndexChanged handler for the City Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_city1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if both cities are valid 
            // perform distance and larger population calculations and display info
            if (this.comboBox_city1.SelectedItem != null && this.comboBox_city2.SelectedItem != null )
            {
                this.textBox_distance.Text = "Loading...";
                this.textBox_largerPop.Text = $"{this.statistics.CompareCitiesPopulation((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem)}";
                decimal dec = this.statistics.CalculateDistanceBetweenCities((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem);
                this.textBox_distance.Text = $"{dec}";
            }
        }

        /// <summary>
        /// IndexChanged handler for the City Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_city2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if both cities are valid 
            // perform distance and larger population calculations and display info
            if (this.comboBox_city1.SelectedItem != null && this.comboBox_city2.SelectedItem != null)
            {
                this.textBox_distance.Text = "Loading...";
                this.textBox_largerPop.Text = $"{this.statistics.CompareCitiesPopulation((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem)}";
                decimal dec = this.statistics.CalculateDistanceBetweenCities((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem);
                this.textBox_distance.Text = $"{dec} km";
            }
        }
    }
}
