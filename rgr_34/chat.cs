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
    public partial class chat : Form
    {
        int cl;
        public chat(int client_id_mess)
        {
            InitializeComponent();
            this.cl = client_id_mess;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void reload()
        {
            textBox_chat.Clear();
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("Select * from message_mail where client_id = '" + cl + "';", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} : {1}", mdr.GetString("author"), mdr.GetString("message"));
                    textBox_chat.Text += rows + Environment.NewLine;
                    //textBox_chat.Text += Environment.NewLine;
                    //employee_id_combo_box.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chat_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
           
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO message_mail(client_id,message, status_message_reade,author) VALUES ('" +
                cl + "','"
                + textBox_send.Text + "', false, 'client');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
                reload();
                textBox_send.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_send_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_MouseMove(object sender, MouseEventArgs e)
        {
            OK.BackColor = Color.Chocolate;
        }

        private void OK_MouseLeave(object sender, EventArgs e)
        {
            OK.BackColor = Color.SaddleBrown;
        }
    }
}
