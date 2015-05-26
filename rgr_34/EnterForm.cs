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
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_log ff = new admin_log();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.Show();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {

        }



        private void button2_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Chocolate;
            
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Chocolate;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SaddleBrown;
        }

        private void EnterForm_BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            check_conn();
        }
        private void check_conn()
        {
            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection MyConn = new MySqlConnection(myConnection);
                MyConn.Open();
                //MySqlCommand command = new MySqlCommand
                //("select * from clients");
                //MySqlDataReader rdr = command.ExecuteReader();
                MyConn.Close();
                MessageBox.Show("Соединение установлено!");
                pictureBox4.Visible = true;
   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ОШИБКА! Соединение не уставлено!");
            }
        }

        private void EnterForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
            //pictureBox3.Visible = true;

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Visible = true;
            //pictureBox3.Visible = false;

        }




    }
}
