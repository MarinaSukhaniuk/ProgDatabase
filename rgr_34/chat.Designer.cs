namespace rgr_34
{
    partial class chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.textBox_chat = new System.Windows.Forms.TextBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_chat
            // 
            this.textBox_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_chat.BackColor = System.Drawing.Color.Lavender;
            this.textBox_chat.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_chat.Location = new System.Drawing.Point(12, 12);
            this.textBox_chat.Multiline = true;
            this.textBox_chat.Name = "textBox_chat";
            this.textBox_chat.ReadOnly = true;
            this.textBox_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_chat.Size = new System.Drawing.Size(526, 268);
            this.textBox_chat.TabIndex = 0;
            this.textBox_chat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_send
            // 
            this.textBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send.BackColor = System.Drawing.Color.Bisque;
            this.textBox_send.Location = new System.Drawing.Point(12, 286);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(438, 68);
            this.textBox_send.TabIndex = 1;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_send_TextChanged);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.BackColor = System.Drawing.Color.SaddleBrown;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OK.Location = new System.Drawing.Point(456, 286);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 68);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.OK.MouseLeave += new System.EventHandler(this.OK_MouseLeave);
            this.OK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OK_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Інформація про автора.htm";
            // 
            // chat
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(550, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.textBox_chat);
            this.Name = "chat";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зв\'язок з компанією технічного обслуговування";
            this.Load += new System.EventHandler(this.chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_chat;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}