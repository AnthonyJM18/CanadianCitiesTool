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
    public partial class ProvinceWindow : Form
    {
        Statistics stats;
        List<Province> provinces;
        public ProvinceWindow(Statistics stat, List<Province> provs)
        {
            InitializeComponent();
            stats = stat;
            provinces = provs;
        }

        private void button_SortCityAsec_Click(object sender, EventArgs e)
        {
            var provincesByCityAcec = stats.RankProvincesByCities(provinces);
            this.listBox_Provinces.Items.Clear();

            foreach (var item in provincesByCityAcec)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.NumCities}");
            }
        }

        private void button_SortCityDesc_Click(object sender, EventArgs e)
        {
            var provincesByCityDesc = stats.RankProvincesByCities(provinces);
            provincesByCityDesc.Reverse();
            this.listBox_Provinces.Items.Clear();
            foreach (var item in provincesByCityDesc)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.NumCities}");
            }
        }

        private void button_SortPopAsec_Click(object sender, EventArgs e)
        {
            var provincesByPopAcec = stats.RankProvincesByPopulation(provinces);
            this.listBox_Provinces.Items.Clear();

            foreach (var item in provincesByPopAcec)
            {
                this.listBox_Provinces.Items.Add($"{item.Name} - {item.Population}");
            }
        }

        private void button_SortPopDesc_Click(object sender, EventArgs e)
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
