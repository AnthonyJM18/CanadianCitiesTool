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
            List<KeyValuePair<string, int>> provinces = stats.RankProvincesByCities();

            foreach(var item in provinces)
            {
                this.listBox_Provinces.Items.Clear();
                this.listBox_Provinces.Items.Add($"{item.Key} - {item.Value}");
            }
        }

        private void button_SortCityDesc_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, int>> provinces = stats.RankProvincesByCities();
            provinces.Reverse();
            foreach (var item in provinces)
            {
                this.listBox_Provinces.Items.Clear();
                this.listBox_Provinces.Items.Add($"{item.Key} - {item.Value}");
            }
        }

        private void button_SortPopAsec_Click(object sender, EventArgs e)
        {

        }

        private void button_SortPopDesc_Click(object sender, EventArgs e)
        {

        }
    }
}
