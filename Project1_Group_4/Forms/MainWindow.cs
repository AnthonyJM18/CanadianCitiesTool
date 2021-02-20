/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/14
 * 
 * Purpose:                     This is the forms class that displays and manages all initialization and events for MainWindow.cs
 */


using Project1_Group_4.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1_Group_4.Forms
{
    public partial class MainWindow : Form
    {
        // DataMembers
        CityInfo selectedCity;
        Statistics stats;
        bool isLoading = false;
        readonly List<Province> provinces;
        
        // Constructor
        public MainWindow()
        {
            // Winforms Init method
            InitializeComponent();
            // Disable buttons until the correct data is present
            this.button_ViewMap.Enabled = false;
            this.button_CompareProvs.Enabled = false;
            this.button_CompareCities.Enabled = false;
            // init province array
            provinces = new List<Province>();
        }

        /// <summary>
        /// Loads all provinces with the appropriate data, and enables buttons that require provinces to be loaded
        /// </summary>
        public void LoadProvinces()
        {
            // Enables buttons
            this.button_CompareProvs.Enabled = true;
            this.button_CompareCities.Enabled = true;
            // Clear province comboBox and list
            this.comboBox_Province.Items.Clear();
            this.provinces.Clear();
            // Add the default/initial value
            this.comboBox_Province.Items.Add("Filter By Province....");
            this.comboBox_Province.SelectedIndex = 0;

            // Get a list of all province names
            List<string> provNames = stats.GetProvinces();
            // foreach province
            foreach (var prov in provNames)
            {
                if (prov != null)
                {
                    // load all the data and init a province object
                    Province p = new Province
                    {
                        Name = prov,
                        Population = stats.DisplayProvincePopulation(prov),
                        NumCities = stats.DisplayProvinceCities(prov).Count,
                        Capital = stats.GetCapital(prov).CityName,
                        SmallestCity = stats.DisplaySmallestPopulationCity(prov).CityName,
                        LargestCity = stats.DisplayLargestPopulationCity(prov).CityName
                    };
                    // add it to the comboBox and province list
                    this.provinces.Add(p);
                    this.comboBox_Province.Items.Add(p.Name);
                }
            }
            // Prevents certain events from triggering during loads
            isLoading = false;
        }

        /// <summary>
        /// Onclick handler for the CompareCities button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CompareCities_Click(object sender, EventArgs e)
        {
            // get a list of all cities in the current file
            List<CityInfo> allcities = new List<CityInfo>();
            foreach (var city in stats.CityCatalogue.Values)
            {
                allcities.Add(city);
            }
            // init the window and open it
            var compare = new CompareWindow(selectedCity, allcities, stats);
            compare.ShowDialog();
        }

        /// <summary>
        /// Onclick handler for the About Label "?" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_About_Click(object sender, EventArgs e)
        {
            // init and show the window
            var about = new AboutWindow();
            about.Show();
        }

        /// <summary>
        /// Onclick handler for the ViewMap button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ViewMap_Click(object sender, EventArgs e)
        {
            // init and show the window
            var map = new MapWindow(stats.ShowCityOnMap(selectedCity));
            map.Show();
        }

        /// <summary>
        /// Onclick handler for the loadCSV button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_LoadCSV_Click(object sender, EventArgs e)
        {
            // Set is loading to prevent certain events
            isLoading = true;
            // Create new stats class with .csv data
            stats = new Statistics("./Data/Canadacities.csv");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
            LoadProvinces();
        }

        /// <summary>
        /// Onclick handler for the loadCSV button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_LoadJSON_Click(object sender, EventArgs e)
        {
            // Set is loading to prevent certain events
            isLoading = true;
            // Create new stats class with .json data
            stats = new Statistics("./Data/Canadacities-JSON.json");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
            LoadProvinces();
        }

        private void Button_LoadXML_Click(object sender, EventArgs e)
        {
            // Set is loading to prevent certain events
            isLoading = true;
            // Create new stats class with .xml data
            stats = new Statistics("./Data/Canadacities-XML.xml");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
            LoadProvinces();
        }

        /// <summary>
        /// IndexChanged handler for the cities listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load city info into the correct fields
            selectedCity = (CityInfo)listBox_cities.SelectedItem;
            this.textBox_CityName.Text = selectedCity.CityName;
            this.textBox_CityPopulation.Text = $"{selectedCity.GetPopulation()}";
            this.textBox_Location.Text = selectedCity.GetLocation().ToString();
            // Load province info into the province fields
            Province province = this.provinces.Find(p => p.Name.ToLower() == selectedCity.GetProvince().ToLower());
            this.textBox_ProvinceName.Text = province.Name;
            this.textBox_ProvincePopulation.Text = $"{province.Population}";
            this.textBox_CapitalCity.Text = province.Capital;
            this.textBox_ProvNumCities.Text = $"{province.NumCities}";
            this.textBox_SmallestCity.Text = $"{province.SmallestCity}";
            this.textBox_LargestCity.Text = $"{province.LargestCity}";
            // if the city is not null, enable the view map button
            if (selectedCity != null)
            {
                this.button_ViewMap.Enabled = true;
            }
        }

        /// <summary>
        /// IndexChanged handler for the Provice combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // if the window is loading dont trigger
                if (!isLoading)
                {
                    if (this.comboBox_Province.SelectedIndex > 0)
                    {
                        listBox_cities.Items.Clear();
                        foreach (var city in stats.DisplayProvinceCities(this.comboBox_Province.Text))
                        {
                            listBox_cities.Items.Add(city);
                        }
                    }
                    else
                    {
                        listBox_cities.Items.Clear();
                        foreach (var city in stats.CityCatalogue.Values)
                        {
                            listBox_cities.Items.Add(city);
                        }
                    }
                }
            }
            catch (Exception) // Empty catch to stop any null errors from popping up error windows.. they dont affect the program
            {

            }
            
        }

        /// <summary>
        /// Onclick handler for the CompareProvs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_CompareProvs_Click(object sender, EventArgs e)
        {
            /// init and show window
            var provWin = new ProvinceWindow(stats, provinces);
            provWin.ShowDialog();
        }
    }
}
