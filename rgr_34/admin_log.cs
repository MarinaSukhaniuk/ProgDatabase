using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rgr_34
{
    public partial class admin_log : Form
    {
        public admin_log()
        {
            InitializeComponent();
        }

        private void button_Loggin_Click(object sender, EventArgs e)
        {
            pbkey2.Visible = false;
            deny.Visible = false;
            //deny_font.Visible = false;
            deny_font.BackColor = Color.LimeGreen;
            deny_font.Visible = true;
            pbkey.Visible = true;
            progressBar1.Visible = true;
            try
            {
               
                timer1.Enabled = true;
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from accounts where username='" + this.textBox_userName.Text + "' and password='" + this.textBox_password.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    
                  
                    count = count + 1;
                    
                }
                
                if (count == 1)
                {

                   // timer1.Enabled = true;
                              deny_font.BackColor = Color.LimeGreen;
                              progressBar1.Value = 100;
                              
                      
                             MessageBox.Show("Username and password is correct");
                             ManagerForm mf = new ManagerForm(this.textBox_userName.Text);
                             mf.Show();
                         
                    
                }
                else if (count > 1)
                {
                    deny_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                     ((System.Byte)(0)), ((System.Byte)(0)));
                    deny_font.Visible = true;
                    progressBar1.Value = 100;
                    pbkey2.Visible = true;
                    deny.Visible = true;
                    MessageBox.Show("Access denied");

                }
                else
                {
                    
                    //progressBar1.Value = 100;

                    pbkey2.Visible = true;
                    deny.Visible = true;
                    //pbkey2.Visible = true;
                    deny_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                     ((System.Byte)(0)), ((System.Byte)(0)));
                    deny_font.Visible = true;
                        MessageBox.Show("Wrong username and password");
                   
                    //progressBar1.ForeColor = Color.Red;
                   
                }
                myConn.Close();

            }
            catch(Exception ex)
            {
               
                progressBar1.Value = 100;
                pbkey2.Visible = true;
                deny.Visible = true;
                deny_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                    ((System.Byte)(0)), ((System.Byte)(0)));
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            pbkey.Visible = false;
            pbkey2.Visible = false;
            deny.Visible = false;
            deny_font.Visible = false;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Loggin_MouseMove(object sender, MouseEventArgs e)
        {
            button_Loggin.BackColor = Color.Chocolate;
        }

        private void button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            button_Exit.BackColor = Color.Chocolate;
        }

        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.SaddleBrown;
        }

        private void button_Loggin_MouseLeave(object sender, EventArgs e)
        {
            button_Loggin.BackColor = Color.SaddleBrown;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.BurlyWood;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.BackgroundImage = new Bitmap("C:/Users/Marina/Pictures/ргр/ee72d9964380e729e020c79531569b71.jpg");
            //progressBar1.BackgroundImageLayout = ImageLayout.Stretch;
            //progressBar1.BackColor = Color.BurlyWood;
            
            progressBar1.Increment(+5);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pbkey2.Visible = true;
            //progressBar2.Visible = true;
            //progressBar1.Value = 0; - обнулить
            
            
        }

        private void deny_Click(object sender, EventArgs e)
        {

        }


    }
}
