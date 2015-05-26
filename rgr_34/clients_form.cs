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
using System.IO;

namespace rgr_34
{
    public partial class clients_form : Form
    {
        string last_n;
        string first_n;
        int model_user;
        int client_id;
        bool status_message_read;
        bool status_message_sent;
        bool status_message_guar_read;
        public clients_form(string ln, string fn)
        {
            InitializeComponent();
            this.last_n = ln;
            this.first_n = fn;
        }
        private void reload()
        {
            //----Вывод имени и фамилии
            label_user_name.Text = last_n;
            label_last_name.Text = first_n;
            //----Ищем подель пользователя и записываем в переменную
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            try
            {
                MySqlCommand mcd = new MySqlCommand("Select * from clients where last_name = '" + last_n + "' and first_name = '" + first_n + "'", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    model_user = Int32.Parse(mdr.GetString("model_id"));
                    client_id = Int32.Parse(mdr.GetString("client_id"));
                    status_message_sent = mdr.GetBoolean("status_massage_sent");
                    status_message_guar_read = mdr.GetBoolean("status_message_guar_read");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //---Загружаем картинку по модели
            MySqlCommand ReadImage = new MySqlCommand("select * from model where model_id=" + model_user, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = ReadImage.ExecuteReader();
                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["image_model"]);       //название колонки
                    if (imgg == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pictureBox1.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //---Заполнение полей модели
            try
            {
                MySqlCommand mcd = new MySqlCommand("Select * from model where model_id = " + model_user, myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                string rows = "0";
                while (mdr.Read())
                {
                    rows = string.Format("{0} | {1} | {2} | {3} | {4}  ", mdr.GetString("model_name")
                         , mdr.GetString("power_mode")
                         , mdr.GetString("water_mode")
                         , mdr.GetString("dimensions")
                         , mdr.GetString("company_id"));
                }
                string[] split = rows.Split('|');
                label2.Text = split[0];
                label3.Text = split[1];
                label4.Text = split[2];
                label5.Text = split[3];
                myConn.Close();

                //---Заполнить поле компании

                myConn.Open();
                MySqlCommand observ_pol = new MySqlCommand("select company_name from company where company_id= " + split[4], myConn);
                object observ = observ_pol.ExecuteScalar();
                myConn.Close();
                label1.Text = observ.ToString();

                //---Заполнить поле конца гарантии

                MySqlCommand client_mcd = new MySqlCommand("Select * from clients where last_name = '" + last_n + "' and first_name = '" + first_n + "'", myConn);
                myConn.Open();
                MySqlDataReader client_mdr = client_mcd.ExecuteReader();
                string rows_client = "0";
                while (client_mdr.Read())
                {
                    rows_client = string.Format("{0} | {1} | {2}   ", client_mdr.GetString("observation_day")
                         , client_mdr.GetString("end_guarantee_day")
                         , client_mdr.GetString("shopping_day"));
                }
                myConn.Close();
                string[] split_client = rows_client.Split('|');
                label6.Text = split_client[0];
                label7.Text = split_client[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clients_form_Load(object sender, EventArgs e)
        {
            reload();
            
            
        }

        private void first_name_Click(object sender, EventArgs e)
        {

        }
        private void label_user_name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string message = null;
            if (status_message_sent == true)
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                try
                {
                    MySqlCommand mcd = new MySqlCommand("Select * from clients_message where client = '" + client_id + "';", myConn);
                    myConn.Open();
                    MySqlDataReader mdr = mcd.ExecuteReader();
                    while (mdr.Read())
                    {
                        message = mdr.GetString("message");
                    }
                    myConn.Close();
                    var result = MessageBox.Show(message, "Read Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        return;
                    }
                    else
                    {
                        try
                        {
                            //--Ставим фолс, что нам отправили сообщение
                            myConn.Open();
                            MySqlCommand client_sent = new MySqlCommand
                             ("UPDATE clients SET status_massage_sent = false WHERE client_id = '" + client_id + "';", myConn);
                            MySqlDataReader myReader2 = client_sent.ExecuteReader();
                            myConn.Close();
                            //--Ставим тру что мы прочитали сообщение
                            myConn.Open();
                            MySqlCommand client_read = new MySqlCommand
                             ("UPDATE clients SET status_message_read = true WHERE client_id = '" + client_id + "';", myConn);
                            MySqlDataReader myReader3 = client_read.ExecuteReader();
                            myConn.Close();
                            //--Увеличиваем дату прохождения следующего ТО
                            myConn.Open();
                            MySqlCommand client_observ_day = new MySqlCommand
                             ("UPDATE clients SET observation_day = adddate(curdate(),2) WHERE client_id = '" + client_id + "';", myConn);
                            MySqlDataReader myReader4 = client_observ_day.ExecuteReader();
                            myConn.Close();
                            MessageBox.Show("Спасибі, що ви виконали ТО у нашому пункті, наступну дату проходження можна переглянути в клієнтській формі");                        
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Извините, но у вас нету не прочитаных сообщений");
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chat ch = new chat(client_id);
            ch.Show();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = null;
            if (status_message_guar_read == false)
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                try
                {
                    MySqlCommand mcd = new MySqlCommand("Select * from guarantee_mail where client_id = '" + client_id + "';", myConn);
                    myConn.Open();
                    MySqlDataReader mdr = mcd.ExecuteReader();
                    while (mdr.Read())
                    {
                        message = mdr.GetString("message");
                    }
                    myConn.Close();
                    var result = MessageBox.Show(message, "Read Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                        return;
                    }
                    else
                    {
                        try
                        {
                            //--Ставим фолс, что нам отправили сообщение
                            //myConn.Open();
                            //MySqlCommand client_sent = new MySqlCommand
                            // ("UPDATE clients SET status_massage_sent = false WHERE client_id = '" + client_id + "';", myConn);
                            //MySqlDataReader myReader2 = client_sent.ExecuteReader();
                            //myConn.Close();
                            //--Ставим тру что мы прочитали сообщение
                            myConn.Open();
                            MySqlCommand client_read = new MySqlCommand
                             ("UPDATE clients SET status_message_guar_read = true WHERE client_id = '" + client_id + "';", myConn);
                            MySqlDataReader myReader3 = client_read.ExecuteReader();
                            myConn.Close();
                            //--Увеличиваем дату прохождения следующего ТО
                            myConn.Open();
                            MySqlCommand client_guar_day = new MySqlCommand
                             ("UPDATE clients SET end_guarantee_day = adddate(curdate(),365) WHERE client_id = '" + client_id + "';", myConn);
                            MySqlDataReader myReader4 = client_guar_day.ExecuteReader();
                            myConn.Close();
                            MessageBox.Show("Спасибі, що ви подовжили гарантію у нашому пункті, наступну дату можна переглянути в клієнтській формі");
                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Извините, но у вас нету не прочитаных сообщений");

            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            chat ch = new chat(client_id);
            ch.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
