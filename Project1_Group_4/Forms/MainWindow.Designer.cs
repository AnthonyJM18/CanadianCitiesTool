
namespace Project1_Group_4.Forms
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_LoadXML = new System.Windows.Forms.Button();
            this.button_LoadJSON = new System.Windows.Forms.Button();
            this.button_LoadCSV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_CompareCities = new System.Windows.Forms.Button();
            this.button_ViewMap = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.textBox_CityPopulation = new System.Windows.Forms.TextBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.comboBox_Province = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ProvinceName = new System.Windows.Forms.TextBox();
            this.textBox_ProvincePopulation = new System.Windows.Forms.TextBox();
            this.textBox_CapitalCity = new System.Windows.Forms.TextBox();
            this.label_About = new System.Windows.Forms.Label();
            this.listBox_cities = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canadian City and Province Statistic Tool";
            // 
            // button_LoadXML
            // 
            this.button_LoadXML.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_LoadXML.FlatAppearance.BorderSize = 4;
            this.button_LoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadXML.Location = new System.Drawing.Point(472, 37);
            this.button_LoadXML.Name = "button_LoadXML";
            this.button_LoadXML.Size = new System.Drawing.Size(138, 33);
            this.button_LoadXML.TabIndex = 1;
            this.button_LoadXML.Text = "Load XML";
            this.button_LoadXML.UseVisualStyleBackColor = true;
            this.button_LoadXML.Click += new System.EventHandler(this.button_LoadXML_Click);
            // 
            // button_LoadJSON
            // 
            this.button_LoadJSON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_LoadJSON.FlatAppearance.BorderSize = 4;
            this.button_LoadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadJSON.Location = new System.Drawing.Point(328, 37);
            this.button_LoadJSON.Name = "button_LoadJSON";
            this.button_LoadJSON.Size = new System.Drawing.Size(138, 33);
            this.button_LoadJSON.TabIndex = 2;
            this.button_LoadJSON.Text = "Load JSON";
            this.button_LoadJSON.UseVisualStyleBackColor = true;
            this.button_LoadJSON.Click += new System.EventHandler(this.button_LoadJSON_Click);
            // 
            // button_LoadCSV
            // 
            this.button_LoadCSV.BackColor = System.Drawing.Color.White;
            this.button_LoadCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_LoadCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_LoadCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_LoadCSV.FlatAppearance.BorderSize = 4;
            this.button_LoadCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoadCSV.Location = new System.Drawing.Point(184, 37);
            this.button_LoadCSV.Name = "button_LoadCSV";
            this.button_LoadCSV.Size = new System.Drawing.Size(138, 33);
            this.button_LoadCSV.TabIndex = 3;
            this.button_LoadCSV.Text = "Load CSV";
            this.button_LoadCSV.UseVisualStyleBackColor = false;
            this.button_LoadCSV.Click += new System.EventHandler(this.button_LoadCSV_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 32);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of Cities";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_CompareCities);
            this.groupBox1.Controls.Add(this.button_ViewMap);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(257, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected City";
            // 
            // button_CompareCities
            // 
            this.button_CompareCities.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_CompareCities.FlatAppearance.BorderSize = 4;
            this.button_CompareCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CompareCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CompareCities.Location = new System.Drawing.Point(132, 237);
            this.button_CompareCities.Name = "button_CompareCities";
            this.button_CompareCities.Size = new System.Drawing.Size(121, 38);
            this.button_CompareCities.TabIndex = 2;
            this.button_CompareCities.Text = "Compare City";
            this.button_CompareCities.UseVisualStyleBackColor = true;
            this.button_CompareCities.Click += new System.EventHandler(this.button_CompareCities_Click);
            // 
            // button_ViewMap
            // 
            this.button_ViewMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_ViewMap.FlatAppearance.BorderSize = 4;
            this.button_ViewMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ViewMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewMap.Location = new System.Drawing.Point(4, 237);
            this.button_ViewMap.Name = "button_ViewMap";
            this.button_ViewMap.Size = new System.Drawing.Size(122, 38);
            this.button_ViewMap.TabIndex = 1;
            this.button_ViewMap.Text = "View Map";
            this.button_ViewMap.UseVisualStyleBackColor = true;
            this.button_ViewMap.Click += new System.EventHandler(this.button_ViewMap_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_CityName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_CityPopulation, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Location, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 37);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 161);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 49);
            this.label6.TabIndex = 6;
            this.label6.Text = "Location";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "City Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Population";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CityName.Location = new System.Drawing.Point(126, 3);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.ReadOnly = true;
            this.textBox_CityName.Size = new System.Drawing.Size(118, 26);
            this.textBox_CityName.TabIndex = 7;
            // 
            // textBox_CityPopulation
            // 
            this.textBox_CityPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CityPopulation.Location = new System.Drawing.Point(126, 56);
            this.textBox_CityPopulation.Name = "textBox_CityPopulation";
            this.textBox_CityPopulation.Size = new System.Drawing.Size(118, 26);
            this.textBox_CityPopulation.TabIndex = 8;
            // 
            // textBox_Location
            // 
            this.textBox_Location.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Location.Location = new System.Drawing.Point(126, 109);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.ReadOnly = true;
            this.textBox_Location.Size = new System.Drawing.Size(118, 26);
            this.textBox_Location.TabIndex = 9;
            // 
            // comboBox_Province
            // 
            this.comboBox_Province.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Province.FormattingEnabled = true;
            this.comboBox_Province.Items.AddRange(new object[] {
            "Filter By Province...."});
            this.comboBox_Province.Location = new System.Drawing.Point(12, 413);
            this.comboBox_Province.Name = "comboBox_Province";
            this.comboBox_Province.Size = new System.Drawing.Size(230, 32);
            this.comboBox_Province.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(533, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 292);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Province Info";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_ProvinceName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_ProvincePopulation, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_CapitalCity, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 161);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 49);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capital City";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 47);
            this.label7.TabIndex = 3;
            this.label7.Text = "Province Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 47);
            this.label8.TabIndex = 4;
            this.label8.Text = "Population";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_ProvinceName
            // 
            this.textBox_ProvinceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ProvinceName.Location = new System.Drawing.Point(126, 3);
            this.textBox_ProvinceName.Name = "textBox_ProvinceName";
            this.textBox_ProvinceName.ReadOnly = true;
            this.textBox_ProvinceName.Size = new System.Drawing.Size(118, 26);
            this.textBox_ProvinceName.TabIndex = 7;
            // 
            // textBox_ProvincePopulation
            // 
            this.textBox_ProvincePopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ProvincePopulation.Location = new System.Drawing.Point(126, 56);
            this.textBox_ProvincePopulation.Name = "textBox_ProvincePopulation";
            this.textBox_ProvincePopulation.ReadOnly = true;
            this.textBox_ProvincePopulation.Size = new System.Drawing.Size(118, 26);
            this.textBox_ProvincePopulation.TabIndex = 8;
            // 
            // textBox_CapitalCity
            // 
            this.textBox_CapitalCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CapitalCity.Location = new System.Drawing.Point(126, 109);
            this.textBox_CapitalCity.Name = "textBox_CapitalCity";
            this.textBox_CapitalCity.ReadOnly = true;
            this.textBox_CapitalCity.Size = new System.Drawing.Size(118, 26);
            this.textBox_CapitalCity.TabIndex = 10;
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.BackColor = System.Drawing.Color.Transparent;
            this.label_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_About.Location = new System.Drawing.Point(771, 9);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(26, 29);
            this.label_About.TabIndex = 8;
            this.label_About.Text = "?";
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            // 
            // listBox_cities
            // 
            this.listBox_cities.FormattingEnabled = true;
            this.listBox_cities.Location = new System.Drawing.Point(12, 198);
            this.listBox_cities.Name = "listBox_cities";
            this.listBox_cities.Size = new System.Drawing.Size(230, 212);
            this.listBox_cities.TabIndex = 9;
            this.listBox_cities.SelectedIndexChanged += new System.EventHandler(this.listBox_cities_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project1_Group_4.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 457);
            this.Controls.Add(this.listBox_cities);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_Province);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_LoadCSV);
            this.Controls.Add(this.button_LoadJSON);
            this.Controls.Add(this.button_LoadXML);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCPST";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_LoadXML;
        private System.Windows.Forms.Button button_LoadJSON;
        private System.Windows.Forms.Button button_LoadCSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.TextBox textBox_CityPopulation;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.ComboBox comboBox_Province;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ProvinceName;
        private System.Windows.Forms.TextBox textBox_ProvincePopulation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CapitalCity;
        private System.Windows.Forms.Button button_CompareCities;
        private System.Windows.Forms.Button button_ViewMap;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.ListBox listBox_cities;
    }
}