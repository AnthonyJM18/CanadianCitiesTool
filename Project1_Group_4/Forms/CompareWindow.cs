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
    public partial class CompareWindow : Form
    {

        private readonly Statistics statistics;
        public CompareWindow(CityInfo selectedCity, List<CityInfo> items, Statistics stats)
        {
            InitializeComponent();
            this.statistics = stats;
            foreach (var item in items)
            {
                this.comboBox_city1.Items.Add(item);
                this.comboBox_city2.Items.Add(item);
            }
            this.comboBox_city1.SelectedItem = selectedCity;
        }

        private void ComboBox_city1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_city1.SelectedItem != null && this.comboBox_city2.SelectedItem != null )
            {
                this.textBox_distance.Text = "Loading...";
                this.textBox_largerPop.Text = $"{this.statistics.CompareCitiesPopulation((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem)}";
                decimal dec = this.statistics.CalculateDistanceBetweenCities((CityInfo)this.comboBox_city1.SelectedItem, (CityInfo)this.comboBox_city2.SelectedItem);
                this.textBox_distance.Text = $"{dec}";
            }
        }

        private void ComboBox_city2_SelectedIndexChanged(object sender, EventArgs e)
        {
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
