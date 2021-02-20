using Project1_Group_4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_Group_4.Forms
{
    public partial class MainWindow : Form
    {
        CityInfo selectedCity;
        Statistics stats;
        bool isLoading = false;
        readonly List<Province> provinces;
        
        public MainWindow()
        {
            InitializeComponent();
            this.button_ViewMap.Enabled = false;
            this.button_CompareProvs.Enabled = false;
            this.button_CompareCities.Enabled = false;
            provinces = new List<Province>();
        }

        public void LoadProvinces()
        {
            this.button_CompareProvs.Enabled = true;
            this.button_CompareCities.Enabled = true;
            this.comboBox_Province.Items.Clear();
            this.provinces.Clear();
            this.comboBox_Province.Items.Add("Filter By Province....");
            this.comboBox_Province.SelectedIndex = 0;
            List<string> provNames = stats.GetProvinces();

            foreach (var prov in provNames)
            {
                if (prov != null)
                {
                    Province p = new Province
                    {
                        Name = prov,
                        Population = stats.DisplayProvincePopulation(prov),
                        NumCities = stats.DisplayProvinceCities(prov).Count,
                        Capital = stats.GetCapital(prov).CityName,
                        SmallestCity = stats.DisplaySmallestPopulationCity(prov).CityName,
                        LargestCity = stats.DisplayLargestPopulationCity(prov).CityName
                    };

                    this.provinces.Add(p);
                    this.comboBox_Province.Items.Add(p.Name);
                }
            }
            isLoading = false;
        }

        private void Button_CompareCities_Click(object sender, EventArgs e)
        {
            List<CityInfo> allcities = new List<CityInfo>();
            foreach (var city in stats.CityCatalogue.Values)
            {
                allcities.Add(city);
            }
            var compare = new CompareWindow(selectedCity, allcities, stats);
            compare.ShowDialog();
        }

        private void Label_About_Click(object sender, EventArgs e)
        {
            var about = new AboutWindow();
            about.Show();
        }

        private void Button_ViewMap_Click(object sender, EventArgs e)
        {
            var map = new MapWindow(stats.ShowCityOnMap(selectedCity));
            map.Show();
        }

        private void Button_LoadCSV_Click(object sender, EventArgs e)
        {
            isLoading = true;
            stats = new Statistics("./Data/Canadacities.csv");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
            LoadProvinces();
        }

        private void Button_LoadJSON_Click(object sender, EventArgs e)
        {
            isLoading = true;
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
            isLoading = true;
            stats = new Statistics("./Data/Canadacities-XML.xml");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
            LoadProvinces();
        }

        private void ListBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity = (CityInfo)listBox_cities.SelectedItem;
            this.textBox_CityName.Text = selectedCity.CityName;
            this.textBox_CityPopulation.Text = $"{selectedCity.GetPopulation()}";
            this.textBox_Location.Text = selectedCity.GetLocation().ToString();
            Province province = this.provinces.Find(p => p.Name.ToLower() == selectedCity.GetProvince().ToLower());
            this.textBox_ProvinceName.Text = province.Name;
            this.textBox_ProvincePopulation.Text = $"{province.Population}";
            this.textBox_CapitalCity.Text = province.Capital;
            this.textBox_ProvNumCities.Text = $"{province.NumCities}";
            this.textBox_SmallestCity.Text = $"{province.SmallestCity}";
            this.textBox_LargestCity.Text = $"{province.LargestCity}";
            if (selectedCity != null)
            {
                this.button_ViewMap.Enabled = true;
            }
        }

        private void ComboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception)
            {

            }
            
        }

        private void Button_CompareProvs_Click(object sender, EventArgs e)
        {
            var provWin = new ProvinceWindow(stats, provinces);
            provWin.ShowDialog();
        }
    }
}
