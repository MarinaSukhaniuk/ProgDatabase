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
    public partial class Form3 : Form
    {
        public static string ln;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void enter_to_user_button_Click(object sender, EventArgs e)
        {
            pr_font.BackColor = Color.LimeGreen;
            pr_font.Visible = true;
            pbkey.Visible = true;
            progressBar1.Visible = true;
            try
            {
                timer1.Enabled = true;
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from clients where last_name='" + this.last_name_tb.Text + "' and first_name='" + this.first_name_tb.Text + "'and phone_number='"+this.phone_tb.Text+"';", myConn);
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
                    pr_font.BackColor = Color.LimeGreen;
                    progressBar1.Value = 100;
                    MessageBox.Show("Username and password is correct");
                    clients_form cf = new clients_form(last_name_tb.Text,first_name_tb.Text);
                    cf.Show();
                }
                else if (count > 1)
                {
                    pr_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                     ((System.Byte)(0)), ((System.Byte)(0)));
                    pr_font.Visible = true;
                    progressBar1.Value = 100;
                    pbkey2.Visible = true;
                    deny.Visible = true;
                    MessageBox.Show("Access denied");
                }
                else
                {
                    pr_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                     ((System.Byte)(0)), ((System.Byte)(0)));
                    pr_font.Visible = true;
                    progressBar1.Value = 100;
                    pbkey2.Visible = true;
                    deny.Visible = true;
                    MessageBox.Show("Wrong username and password");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                pr_font.BackColor = Color.FromArgb(((System.Byte)(192)),
                     ((System.Byte)(0)), ((System.Byte)(0)));
                pr_font.Visible = true;
                progressBar1.Value = 100;
                pbkey2.Visible = true;
                deny.Visible = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enter_to_user_button_MouseMove(object sender, MouseEventArgs e)
        {
            enter_to_user_button.BackColor = Color.Chocolate;
        }

        private void enter_to_user_button_MouseLeave(object sender, EventArgs e)
        {
            enter_to_user_button.BackColor = Color.SaddleBrown;
        }

        private void exit_cl_ent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_cl_ent_MouseMove(object sender, MouseEventArgs e)
        {
            exit_cl_ent.BackColor = Color.Chocolate;
        }

        private void exit_cl_ent_MouseLeave(object sender, EventArgs e)
        {
            exit_cl_ent.BackColor = Color.SaddleBrown;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            pbkey.Visible = false;
            pbkey2.Visible = false;
            deny.Visible = false;
            pr_font.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            pbkey.Visible = true;
            progressBar1.Increment(+5);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void progressBar1_ForeColorChanged(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;
        }


    }
}
