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
            var map = new MapWindow();
            map.Show();
        }

        private void button_LoadCSV_Click(object sender, EventArgs e)
        {

        }

        private void button_LoadJSON_Click(object sender, EventArgs e)
        {

        }

        private void button_LoadXML_Click(object sender, EventArgs e)
        {

        }
    }
}
