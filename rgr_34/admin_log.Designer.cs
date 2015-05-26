namespace rgr_34
{
    partial class admin_log
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_log));
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_Loggin = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbkey = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbkey2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.deny_font = new System.Windows.Forms.PictureBox();
            this.deny = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deny_font)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deny)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(263, 120);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '●';
            this.textBox_password.Size = new System.Drawing.Size(170, 24);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_userName.Location = new System.Drawing.Point(263, 50);
            this.textBox_userName.Multiline = true;
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(170, 24);
            this.textBox_userName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_userName, "Щоб авторизуватись, як адміністратор, введіть у це текстове поле: \"admin\".\r\nЩоб а" +
        "вторизуватись у режимі працівника, введіть у це текстове поле: \"emp\".\r\nЦі данні " +
        "стоять за замовчуванням.");
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.BurlyWood;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(168, 125);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(63, 16);
            this.label_password.TabIndex = 15;
            this.label_password.Text = "Пароль";
            // 
            // label_username
            // 
            this.label_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_username.AutoEllipsis = true;
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.BurlyWood;
            this.label_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_username.Location = new System.Drawing.Point(171, 54);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(29, 20);
            this.label_username.TabIndex = 14;
            this.label_username.Text = "Ім\'я";
            this.label_username.UseCompatibleTextRendering = true;
            // 
            // button_Loggin
            // 
            this.button_Loggin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Loggin.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_Loggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Loggin.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button_Loggin.FlatAppearance.BorderSize = 0;
            this.button_Loggin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Loggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Loggin.ForeColor = System.Drawing.Color.White;
            this.button_Loggin.Location = new System.Drawing.Point(329, 180);
            this.button_Loggin.Name = "button_Loggin";
            this.button_Loggin.Size = new System.Drawing.Size(104, 57);
            this.button_Loggin.TabIndex = 3;
            this.button_Loggin.Text = "Ввійти";
            this.toolTip1.SetToolTip(this.button_Loggin, "Якщо Ви ввели всі данні вірно, то натисніть цю кнопку, щоб відкрити наступну форм" +
        "у.");
            this.button_Loggin.UseVisualStyleBackColor = true;
            this.button_Loggin.ForeColorChanged += new System.EventHandler(this.button_Loggin_Click);
            this.button_Loggin.Click += new System.EventHandler(this.button_Loggin_Click);
            this.button_Loggin.MouseLeave += new System.EventHandler(this.button_Loggin_MouseLeave);
            this.button_Loggin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Loggin_MouseMove);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Exit.BackColor = System.Drawing.Color.SaddleBrown;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(34, 180);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(104, 57);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Вихід";
            this.toolTip1.SetToolTip(this.button_Exit, "Натисність цю кнопку, щоб закрити цю форму.");
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            this.button_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_Exit_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbkey
            // 
            this.pbkey.BackColor = System.Drawing.Color.Green;
            this.pbkey.Image = ((System.Drawing.Image)(resources.GetObject("pbkey.Image")));
            this.pbkey.Location = new System.Drawing.Point(-4, -1);
            this.pbkey.Name = "pbkey";
            this.pbkey.Size = new System.Drawing.Size(31, 29);
            this.pbkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkey.TabIndex = 21;
            this.pbkey.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(185, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pbkey2
            // 
            this.pbkey2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbkey2.Image = ((System.Drawing.Image)(resources.GetObject("pbkey2.Image")));
            this.pbkey2.Location = new System.Drawing.Point(-4, -1);
            this.pbkey2.Name = "pbkey2";
            this.pbkey2.Size = new System.Drawing.Size(31, 29);
            this.pbkey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbkey2.TabIndex = 24;
            this.pbkey2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.BurlyWood;
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(-4, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(482, 20);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.button_Loggin_Click);
            // 
            // deny_font
            // 
            this.deny_font.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deny_font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deny_font.Location = new System.Drawing.Point(-4, -1);
            this.deny_font.Name = "deny_font";
            this.deny_font.Size = new System.Drawing.Size(482, 29);
            this.deny_font.TabIndex = 25;
            this.deny_font.TabStop = false;
            this.deny_font.Visible = false;
            // 
            // deny
            // 
            this.deny.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deny.BackColor = System.Drawing.Color.Red;
            this.deny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deny.Location = new System.Drawing.Point(26, 6);
            this.deny.Name = "deny";
            this.deny.Size = new System.Drawing.Size(452, 20);
            this.deny.TabIndex = 26;
            this.deny.TabStop = false;
            this.toolTip1.SetToolTip(this.deny, "Якщо ПрогрессБар дійшов до кінця, і залишився зеленим, то чекайте появи наступної" +
        " форми.\r\nЯкщо ПрогрессБар став червоного кольору, то це означає неправильний пар" +
        "оль чи проблеми з інтернетом.");
            this.deny.Visible = false;
            this.deny.WaitOnLoad = true;
            this.deny.Click += new System.EventHandler(this.deny_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // helpProvider2
            // 
            this.helpProvider2.HelpNamespace = "Інформація про автора.htm";
            // 
            // admin_log
            // 
            this.AcceptButton = this.button_Loggin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.deny);
            this.Controls.Add(this.pbkey2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbkey);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_Loggin);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.deny_font);
            this.Name = "admin_log";
            this.helpProvider2.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід для персоналу";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbkey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deny_font)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_Loggin;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbkey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbkey2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox deny_font;
        private System.Windows.Forms.PictureBox deny;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider2;
    }
}

