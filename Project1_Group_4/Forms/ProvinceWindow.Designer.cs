
namespace Project1_Group_4.Forms
{
    partial class ProvinceWindow
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
            this.listBox_Provinces = new System.Windows.Forms.ListBox();
            this.button_SortCityAsec = new System.Windows.Forms.Button();
            this.button_SortCityDesc = new System.Windows.Forms.Button();
            this.button_SortPopAsec = new System.Windows.Forms.Button();
            this.button_SortPopDesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Provinces
            // 
            this.listBox_Provinces.FormattingEnabled = true;
            this.listBox_Provinces.Location = new System.Drawing.Point(13, 13);
            this.listBox_Provinces.Name = "listBox_Provinces";
            this.listBox_Provinces.Size = new System.Drawing.Size(292, 238);
            this.listBox_Provinces.TabIndex = 0;
            // 
            // button_SortCityAsec
            // 
            this.button_SortCityAsec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_SortCityAsec.FlatAppearance.BorderSize = 4;
            this.button_SortCityAsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SortCityAsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SortCityAsec.Location = new System.Drawing.Point(13, 257);
            this.button_SortCityAsec.Name = "button_SortCityAsec";
            this.button_SortCityAsec.Size = new System.Drawing.Size(292, 32);
            this.button_SortCityAsec.TabIndex = 1;
            this.button_SortCityAsec.Text = "Sort By Cities (Ascending)";
            this.button_SortCityAsec.UseVisualStyleBackColor = true;
            this.button_SortCityAsec.Click += new System.EventHandler(this.button_SortCityAsec_Click);
            // 
            // button_SortCityDesc
            // 
            this.button_SortCityDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_SortCityDesc.FlatAppearance.BorderSize = 4;
            this.button_SortCityDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SortCityDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SortCityDesc.Location = new System.Drawing.Point(13, 295);
            this.button_SortCityDesc.Name = "button_SortCityDesc";
            this.button_SortCityDesc.Size = new System.Drawing.Size(292, 32);
            this.button_SortCityDesc.TabIndex = 2;
            this.button_SortCityDesc.Text = "Sort By Cities (Descending)";
            this.button_SortCityDesc.UseVisualStyleBackColor = true;
            this.button_SortCityDesc.Click += new System.EventHandler(this.button_SortCityDesc_Click);
            // 
            // button_SortPopAsec
            // 
            this.button_SortPopAsec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_SortPopAsec.FlatAppearance.BorderSize = 4;
            this.button_SortPopAsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SortPopAsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SortPopAsec.Location = new System.Drawing.Point(13, 333);
            this.button_SortPopAsec.Name = "button_SortPopAsec";
            this.button_SortPopAsec.Size = new System.Drawing.Size(292, 32);
            this.button_SortPopAsec.TabIndex = 3;
            this.button_SortPopAsec.Text = "Sort By Population (Ascending)";
            this.button_SortPopAsec.UseVisualStyleBackColor = true;
            this.button_SortPopAsec.Click += new System.EventHandler(this.button_SortPopAsec_Click);
            // 
            // button_SortPopDesc
            // 
            this.button_SortPopDesc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.button_SortPopDesc.FlatAppearance.BorderSize = 4;
            this.button_SortPopDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SortPopDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SortPopDesc.Location = new System.Drawing.Point(13, 371);
            this.button_SortPopDesc.Name = "button_SortPopDesc";
            this.button_SortPopDesc.Size = new System.Drawing.Size(292, 32);
            this.button_SortPopDesc.TabIndex = 4;
            this.button_SortPopDesc.Text = "Sort By Population (Descending)";
            this.button_SortPopDesc.UseVisualStyleBackColor = true;
            this.button_SortPopDesc.Click += new System.EventHandler(this.button_SortPopDesc_Click);
            // 
            // ProvinceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project1_Group_4.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(317, 414);
            this.Controls.Add(this.button_SortPopDesc);
            this.Controls.Add(this.button_SortPopAsec);
            this.Controls.Add(this.button_SortCityDesc);
            this.Controls.Add(this.button_SortCityAsec);
            this.Controls.Add(this.listBox_Provinces);
            this.MaximizeBox = false;
            this.Name = "ProvinceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProvinceWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Provinces;
        private System.Windows.Forms.Button button_SortCityAsec;
        private System.Windows.Forms.Button button_SortCityDesc;
        private System.Windows.Forms.Button button_SortPopAsec;
        private System.Windows.Forms.Button button_SortPopDesc;
    }
}