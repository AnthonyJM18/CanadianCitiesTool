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
    public partial class MapWindow : Form
    {
        public MapWindow(string url)
        {
            InitializeComponent();
            if (url != null)
            {
                this.webBrowser_map.Navigate(url);
            }
            
        }
    }
}
