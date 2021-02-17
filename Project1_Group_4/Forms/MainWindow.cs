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
        List<Province> provinces;
        
        public MainWindow()
        {
            InitializeComponent();
            this.button_ViewMap.Enabled = false;
            provinces = new List<Province>();
        }

        public void LoadProvinces()
        {
            this.comboBox_Province.Items.Clear();
            this.comboBox_Province.Items.Add("Filter By Province....");
            this.comboBox_Province.SelectedIndex = 0;
            List<string> provinces = stats.GetProvinces();
            Province p = new Province();

            foreach (var prov in provinces)
            {
                p.Name = prov;
                p.Population = stats.DisplayProvincePopulation(prov);
                p.NumCities = stats.DisplayProvinceCities(prov).Count;
                p.Capital = stats.GetCapital(prov).CityName;

                this.provinces.Add(p);
                if (prov != null)
                {
                    this.comboBox_Province.Items.Add(prov);
                }
            }
            isLoading = false;
        }

        private void button_CompareCities_Click(object sender, EventArgs e)
        {
            var compare = new CompareWindow(selectedCity, listBox_cities.Items, stats);
            compare.ShowDialog();
        }

        private void label_About_Click(object sender, EventArgs e)
        {
            var about = new AboutWindow();
            about.Show();
        }

        private void button_ViewMap_Click(object sender, EventArgs e)
        {
            var map = new MapWindow(stats.ShowCityOnMap(selectedCity));
            map.Show();
        }

        private void button_LoadCSV_Click(object sender, EventArgs e)
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

        private void button_LoadJSON_Click(object sender, EventArgs e)
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

        private void button_LoadXML_Click(object sender, EventArgs e)
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

        private void listBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity = (CityInfo)listBox_cities.SelectedItem;
            this.textBox_CityName.Text = selectedCity.CityName;
            this.textBox_CityPopulation.Text = $"{selectedCity.GetPopulation()}";
            this.textBox_Location.Text = selectedCity.GetLocation().ToString();
            //Province province = this.provinces.Find(p => p.Name.ToLower() == selectedCity.GetProvince().ToLower());
            //this.textBox_ProvinceName.Text = province.Name;
            //this.textBox_ProvincePopulation.Text = $"{province.Population}";
            //this.textBox_CapitalCity.Text = province.Capital;
            //this.textBox_ProvNumCities.Text = $"{province.NumCities}";
            if (selectedCity != null)
            {
                this.button_ViewMap.Enabled = true;
            }
        }

        private void comboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button_CompareProvs_Click(object sender, EventArgs e)
        {
            var provWin = new ProvinceWindow(stats);
            provWin.ShowDialog();
        }
    }
}
