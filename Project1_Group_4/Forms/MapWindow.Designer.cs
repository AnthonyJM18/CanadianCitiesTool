namespace Project1_Group_4.Forms
{
    partial class MapWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser_map = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_map
            // 
            this.webBrowser_map.AllowNavigation = false;
            this.webBrowser_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_map.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_map.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_map.Name = "webBrowser_map";
            this.webBrowser_map.ScriptErrorsSuppressed = true;
            this.webBrowser_map.Size = new System.Drawing.Size(1184, 561);
            this.webBrowser_map.TabIndex = 0;
            this.webBrowser_map.Url = new System.Uri("https://www.bing.com/maps?osid=1ef6d360-9e26-4037-a160-f8f8495a46db&cp=43.197741~" +
        "-79.560526&lvl=11&style=h&v=2&sV=2&form=S00027", System.UriKind.Absolute);
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.webBrowser_map);
            this.Name = "MapWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MapWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_map;
    }
}