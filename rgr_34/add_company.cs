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
    public partial class add_company : Form
    {
        public add_company()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_comp_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //MySqlCommand company_add = new MySqlCommand("Insert into company (company_name,company_country,company_city,company_coordinates,date_create) values('"
                //    + this.company_name.Text + "','" + this.company_country.Text + "','" + this.company_city.Text + "',curdate());", myConn);
                //Insert into company (company_name,company_country,company_city,
                //    company_coordinates,date_create) 
                //values('Bosh','Stuttgart','Germany','48°47′N 9°11′E',curdate());
                 MySqlCommand company_add = new MySqlCommand ("Insert into company (company_name,company_country,company_city,company_coordinates,company_model_count) values ('"+
                     this.company_name_tb.Text+"','"
                     +this.company_country_tb.Text+"','"
                     +this.company_city_tb.Text+"','"
                     +this.company_coord_tb.Text+"','0');",myConn);
                myConn.Open();
                MySqlDataReader myReader = company_add.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Компанія була додана");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_comp_MouseMove(object sender, MouseEventArgs e)
        {
            exit_comp.BackColor = Color.Chocolate;
        }

        private void exit_comp_MouseLeave(object sender, EventArgs e)
        {
            exit_comp.BackColor = Color.SaddleBrown;
        }

        private void add_comp_MouseMove(object sender, MouseEventArgs e)
        {
            add_comp.BackColor = Color.Chocolate;
        }

        private void add_comp_MouseLeave(object sender, EventArgs e)
        {
            add_comp.BackColor = Color.SaddleBrown;
        }

        private void exit_comp_Click(object sender, EventArgs e)
        {

        }
    }
}
