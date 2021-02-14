﻿using Project1_Group_4.Classes;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_CompareCities_Click(object sender, EventArgs e)
        {
            var compare = new CompareWindow();
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
            stats = new Statistics("./Data/Canadacities.csv");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
        }

        private void button_LoadJSON_Click(object sender, EventArgs e)
        {
            stats = new Statistics("./Data/Canadacities-JSON.json");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
        }

        private void button_LoadXML_Click(object sender, EventArgs e)
        {
            stats = new Statistics("./Data/Canadacities-XML.xml");
            listBox_cities.Items.Clear();
            foreach (var city in stats.CityCatalogue.Values)
            {
                listBox_cities.Items.Add(city);
            }
        }

        private void listBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCity = (CityInfo)listBox_cities.SelectedItem;
            this.textBox_CityName.Text = selectedCity.CityName;
            this.textBox_CityPopulation.Text = $"{selectedCity.GetPopulation()}";
            this.textBox_Location.Text = selectedCity.GetLocation().ToString();
            this.textBox_ProvinceName.Text = selectedCity.GetProvince();
            this.textBox_ProvincePopulation.Text = $"{stats.DisplayProvincePopulation(selectedCity.GetProvince())}";
            this.textBox_CapitalCity.Text = stats.GetCapital(selectedCity.GetProvince()).CityName;

        }
    }
}
