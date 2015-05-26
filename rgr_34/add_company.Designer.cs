namespace rgr_34
{
    partial class add_company
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
            this.company_name_tb = new System.Windows.Forms.TextBox();
            this.company_country_tb = new System.Windows.Forms.TextBox();
            this.company_city_tb = new System.Windows.Forms.TextBox();
            this.company_coord_tb = new System.Windows.Forms.TextBox();
            this.company_name = new System.Windows.Forms.Label();
            this.company_country = new System.Windows.Forms.Label();
            this.company_city = new System.Windows.Forms.Label();
            this.coordinates = new System.Windows.Forms.Label();
            this.add_comp = new System.Windows.Forms.Button();
            this.exit_comp = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // company_name_tb
            // 
            this.company_name_tb.Location = new System.Drawing.Point(45, 41);
            this.company_name_tb.Name = "company_name_tb";
            this.company_name_tb.Size = new System.Drawing.Size(207, 20);
            this.company_name_tb.TabIndex = 0;
            this.company_name_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // company_country_tb
            // 
            this.company_country_tb.Location = new System.Drawing.Point(45, 83);
            this.company_country_tb.Name = "company_country_tb";
            this.company_country_tb.Size = new System.Drawing.Size(207, 20);
            this.company_country_tb.TabIndex = 1;
            // 
            // company_city_tb
            // 
            this.company_city_tb.Location = new System.Drawing.Point(45, 126);
            this.company_city_tb.Name = "company_city_tb";
            this.company_city_tb.Size = new System.Drawing.Size(207, 20);
            this.company_city_tb.TabIndex = 2;
            // 
            // company_coord_tb
            // 
            this.company_coord_tb.Location = new System.Drawing.Point(45, 166);
            this.company_coord_tb.Name = "company_coord_tb";
            this.company_coord_tb.Size = new System.Drawing.Size(207, 20);
            this.company_coord_tb.TabIndex = 3;
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.Location = new System.Drawing.Point(45, 22);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(85, 13);
            this.company_name.TabIndex = 4;
            this.company_name.Text = "Назва компанії";
            // 
            // company_country
            // 
            this.company_country.AutoSize = true;
            this.company_country.Location = new System.Drawing.Point(45, 67);
            this.company_country.Name = "company_country";
            this.company_country.Size = new System.Drawing.Size(41, 13);
            this.company_country.TabIndex = 5;
            this.company_country.Text = "Країна";
            // 
            // company_city
            // 
            this.company_city.AutoSize = true;
            this.company_city.Location = new System.Drawing.Point(45, 110);
            this.company_city.Name = "company_city";
            this.company_city.Size = new System.Drawing.Size(35, 13);
            this.company_city.TabIndex = 6;
            this.company_city.Text = "Місто";
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.Location = new System.Drawing.Point(45, 151);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(67, 13);
            this.coordinates.TabIndex = 7;
            this.coordinates.Text = "Координати";
            // 
            // add_comp
            // 
            this.add_comp.BackColor = System.Drawing.Color.SaddleBrown;
            this.add_comp.FlatAppearance.BorderSize = 0;
            this.add_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_comp.Location = new System.Drawing.Point(170, 205);
            this.add_comp.Name = "add_comp";
            this.add_comp.Size = new System.Drawing.Size(82, 32);
            this.add_comp.TabIndex = 8;
            this.add_comp.Text = "Додати";
            this.add_comp.UseVisualStyleBackColor = false;
            this.add_comp.Click += new System.EventHandler(this.add_comp_Click);
            this.add_comp.MouseLeave += new System.EventHandler(this.add_comp_MouseLeave);
            this.add_comp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.add_comp_MouseMove);
            // 
            // exit_comp
            // 
            this.exit_comp.BackColor = System.Drawing.Color.SaddleBrown;
            this.exit_comp.FlatAppearance.BorderSize = 0;
            this.exit_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_comp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_comp.Location = new System.Drawing.Point(45, 205);
            this.exit_comp.Name = "exit_comp";
            this.exit_comp.Size = new System.Drawing.Size(85, 32);
            this.exit_comp.TabIndex = 9;
            this.exit_comp.Text = "Вихід";
            this.exit_comp.UseVisualStyleBackColor = false;
            this.exit_comp.Click += new System.EventHandler(this.exit_comp_Click);
            this.exit_comp.MouseLeave += new System.EventHandler(this.exit_comp_MouseLeave);
            this.exit_comp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_comp_MouseMove);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Інформація про автора.htm";
            // 
            // add_company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exit_comp);
            this.Controls.Add(this.add_comp);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.company_city);
            this.Controls.Add(this.company_country);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.company_coord_tb);
            this.Controls.Add(this.company_city_tb);
            this.Controls.Add(this.company_country_tb);
            this.Controls.Add(this.company_name_tb);
            this.Name = "add_company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Додати компанію";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox company_name_tb;
        private System.Windows.Forms.TextBox company_country_tb;
        private System.Windows.Forms.TextBox company_city_tb;
        private System.Windows.Forms.TextBox company_coord_tb;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.Label company_country;
        private System.Windows.Forms.Label company_city;
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Button add_comp;
        private System.Windows.Forms.Button exit_comp;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}