/* Project Group Number:        4
 * Project Members:             Anthony Merante, Colin Manliclic, Zina Long
 * Date:                        2021/02/14
 * 
 * Purpose:                     This is the forms class that displays and manages all initialization and events for MapWindow.cs
 */

using System.Windows.Forms;

namespace Project1_Group_4.Forms
{
    public partial class MapWindow : Form
    {
        /// <summary>
        /// Constructor for the map window
        /// </summary>
        /// <param name="url"></param>
        public MapWindow(string url)
        {
            // If the url is valid, navigate to it
            InitializeComponent();
            if (url != null)
            {
                this.webBrowser_map.Navigate(url);
            }
            
        }
    }
}
