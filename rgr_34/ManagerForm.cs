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
    public partial class ManagerForm : Form
    {
        string login;
        public ManagerForm(string login)
        {
            InitializeComponent();
            timer1.Start();
            if (login == "emp")
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                label29.Visible = true;
                label41.Visible = true;
                label42.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            Font f;
            Brush backBrush;
            // Get the item from the collection.
            TabPage _tabPage = comb_clients1.TabPages[e.Index];
            //var border;
            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = comb_clients1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
               
            {
                
                
                
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Chocolate, e.Bounds);
                backBrush = new SolidBrush(Color.BurlyWood);
                
                
                
            }
            else
            {
                //f = e.Font;
                _textBrush = new System.Drawing.SolidBrush(Color.Chocolate);
                //e.DrawBackground();
                g.FillRectangle(Brushes.SaddleBrown, e.Bounds);
                //backBrush = new SolidBrush(Color.Coral);
                _textBrush = new SolidBrush(Color.White);
                
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            //_tabBounds.Width = 0;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
            
 
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            this.Timer.Text = Date.ToString();
        }

        public void reload()
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            try
            {
                combo_box_company.Items.Clear();
                combo_box_manager_id.Items.Clear();
                employee_id_combo_box.Items.Clear();
                model_id_combo_box.Items.Clear();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //-------------------------------------------------Инициализация добавление товара
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("Select * from company", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0},{1}", mdr.GetString("company_name"), mdr.GetString("company_id"));
                    combo_box_company.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //-------------------------------------------------Инициализация сотрудника
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("Select * from manager", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{2} | {0} {1}", mdr.GetString("first_name"), mdr.GetString("last_name"), mdr.GetString("manager_id"));
                    combo_box_manager_id.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //-------------------------------------------------Инициализация клиента - какой сотрудник продал
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("Select * from employee", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{2} | {0} {1}", mdr.GetString("first_name"), mdr.GetString("last_name"), mdr.GetString("employee_id"));
                    employee_id_combo_box.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //----Инициализация клиента - товар
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("select m.model_id, m.model_name, c.company_name from model m  join company c on m.company_id = c.company_id;", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} | {1} {2}", mdr.GetString("model_id"), mdr.GetString("company_name"), mdr.GetString("model_name"));
                    model_id_combo_box.Items.Add(rows);
                    
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                notes.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("select client_id, first_name, last_name from guarantee_days_client;", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} . {1} {2}", mdr.GetString("client_id"), mdr.GetString("first_name"), mdr.GetString("last_name"));
                    //model_id_combo_box.Items.Add(rows);

                    notes.Text += rows + Environment.NewLine;
                  
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                notes2.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine;
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("select client_id, first_name, last_name from observation_days_client;", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} . {1} {2}", mdr.GetString("client_id"), mdr.GetString("first_name"), mdr.GetString("last_name"));
                    //model_id_combo_box.Items.Add(rows);

                    notes2.Text += rows + Environment.NewLine;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coffe_marinaDataSet.model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.coffe_marinaDataSet.model);
            dataGridView1.DataSource = GetModel("model");
            dataGridView_clients.DataSource = GetModel("clients");
            dataGridView_employee.DataSource = GetModel("employee");
            reload();
        }

        private void add_goods_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] split = combo_box_company.SelectedItem.ToString().Split(',');

            byte[] imageBT = null;
            FileStream fstream = new FileStream(this.textBox_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader binread = new BinaryReader(fstream);
            imageBT = binread.ReadBytes((int)fstream.Length);

            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //MySqlCommand test = new MySqlCommand("Insert into model (company_id , model_name, model_type, power_mode, water_mode, dimensions, date_create) values ('5','GT','caps','300','200','25323',curdate());", myConn);
                myConn.Open();
                MySqlCommand add_model = new MySqlCommand("Insert into model (company_id , model_name, model_type, power_mode, water_mode, dimensions, date_create, guarantee_days, observation, image_model) values ('"
                + Int32.Parse(split[1]) + "','"
                + this.name_model.Text + "','"
                + this.type_model.Text + "','"
                + this.power_model.Text + "','"
                + this.water_model.Text + "','"
                + this.dimensions_model.Text + "',"
                + "curdate()" + ",'"
                + this.guarantee_days.Text + "','"
                + this.observ.Text + "'"
                +",@IMG);", myConn);
                add_model.Parameters.Add("@IMG", MySqlDbType.Blob).Value = imageBT;
                MySqlDataReader myReader = add_model.ExecuteReader();
                myConn.Close();
                myConn.Open();
                MySqlCommand EmpCount = new MySqlCommand
                 ("UPDATE company SET company_model_count = company_model_count + 1 WHERE company_id = '" + split[1] + "';", myConn);
                MySqlDataReader myReader1 = EmpCount.ExecuteReader();
                myConn.Close();
                reload();
                MessageBox.Show("Товар був доданий в базу до адміна, очікуйте підтвердження");
                clear_my_text();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_my_text();
        }
        private void clear_my_text()
        {
            name_model.Clear();
            type_model.Clear();
            power_model.Clear();
            water_model.Clear();
            dimensions_model.Clear();
            guarantee_days.Clear();
        }

        private void list_clients_Click(object sender, EventArgs e)
        {

        }

        private void combo_box_company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void not_search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_company comp = new add_company();
            comp.Show();
        }
        private DataTable GetModel(string from)
        {
            DataTable dt = new DataTable();
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            try
            {
                myConn.Open();
                MySqlCommand mcd = new MySqlCommand("Select * from "+ from +"", myConn);
                MySqlDataReader mdr = mcd.ExecuteReader();
                if (mdr.HasRows)
                {
                    dt.Load(mdr);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetModel("model");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void clear_employee_Click_1(object sender, EventArgs e)
        {
          
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            string[] split = combo_box_manager_id.SelectedItem.ToString().Split('|');
            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand AddEmp = new MySqlCommand
                       ("INSERT INTO employee (first_name,last_name, city, adress, phone_number, salary,  hire_date , manager_id, client_count) VALUES ('"
                       + this.first_name_employee.Text + "','"
                       + this.last_name_employee.Text + "','"
                       + this.city_employee.Text + "','"
                       + this.adress_employee.Text + "','"
                       + this.phone_employee.Text + "','"
                       + this.salary_employee.Text + "',curdate(),'" + split[0] + "','0');", myConn);
                MySqlDataReader myReader = AddEmp.ExecuteReader();
                myConn.Close();
                //--------увеличить ячейку на 1
                myConn.Open();
                MySqlCommand EmpCount = new MySqlCommand
                 ("UPDATE manager SET emploers_control = emploers_control + 1 WHERE manager_id = '" + split[0] + "';", myConn);
                MySqlDataReader myReader1 = EmpCount.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Співробітник був доданий в базу");
                employee_clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void employee_clear()
        {
            first_name_employee.Clear();
            last_name_employee.Clear();
            city_employee.Clear();
            adress_employee.Clear();
            phone_employee.Clear();
            salary_employee.Clear();
        }
        private void clear_employee_Click(object sender, EventArgs e)
        {
            first_name_employee.Clear();
            last_name_employee.Clear();
            city_employee.Clear();
            adress_employee.Clear();
            phone_employee.Clear();
            salary_employee.Clear();
        }

        //------------------------------------------ДОДАВАННЯ КЛІЄНТУ
        private void Add_new_client_Click(object sender, EventArgs e)
        {
            string[] split_model = model_id_combo_box.SelectedItem.ToString().Split('|');
            string[] split_employee = employee_id_combo_box.SelectedItem.ToString().Split('|');
            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                //----Получить число через сколько проходить ТО
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand observ_pol = new MySqlCommand("select observation from model where model_id= " + split_model[0], myConn);
                object observ = observ_pol.ExecuteScalar();
                myConn.Close();
                //----Получить гарантию выбранной модели
                myConn.Open();
                MySqlCommand guarant_day = new MySqlCommand("select guarantee_days from model where model_id= " + split_model[0], myConn);
                object guarant = guarant_day.ExecuteScalar();
                myConn.Close();
                //----Запись новых данных о клиенте
                myConn.Open();
                MySqlCommand AddClient = new MySqlCommand
                       ("INSERT INTO clients (first_name ,last_name, city, adress, phone_number, model_id, employee_id, shopping_day,  status_massage_sent, status_message_read, status_message_guar_read, observation_day,end_guarantee_day) VALUES ('"
                       + this.first_name_client.Text + "','"
                       + this.last_name_client.Text + "','"
                       + this.city_client.Text + "','"
                       + this.adress_client.Text + "','"
                       + this.phone_client.Text + "','"
                       + split_model[0] + "','"
                       + split_employee[0] + "'"
                       + ",curdate(),false,false, false, adddate(curdate()," + observ + "),adddate(curdate()," +guarant+"));", myConn);
                MySqlDataReader myReader = AddClient.ExecuteReader();
                myConn.Close();
                //----- Апдейт количества клиентов у сотрудника
                myConn.Open();
                MySqlCommand EmpCount = new MySqlCommand
                 ("UPDATE employee SET client_count = client_count + 1 WHERE employee_id = '" + split_employee[0] + "';", myConn);
                MySqlDataReader myReader1 = EmpCount.ExecuteReader();
                myConn.Close();
                //----- Апдейт количества моделей
                myConn.Open();
                MySqlCommand modelCount = new MySqlCommand
                 ("UPDATE model SET clients_count = clients_count + 1 WHERE model_id = '" + split_model[0] + "';", myConn);
                MySqlDataReader myReader2 = modelCount.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Клієнт був доданий в базу до адміна, очікуйте підтвердження");
                clear_my_text_clients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear_my_text_clients()
        {
            first_name_client.Clear();
            last_name_client.Clear();
            city_client.Clear();
            adress_client.Clear();
            phone_client.Clear();
            //guarantee.Clear();
        }

        private void clear_client_Click(object sender, EventArgs e)
        {
            clear_my_text_clients();
        }

        private void combo_box_manager_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_manager_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand AddManager = new MySqlCommand
                       ("INSERT INTO manager(first_name,last_name, city, adress, phone_number, salary,emploers_control) VALUES ('"
                       + this.first_name_manager.Text + "','"
                       + this.last_name_manager.Text + "','"
                       + this.city_manager.Text + "','"
                       + this.adress_manager.Text + "','"
                       + this.phone_manager.Text + "','"
                       + this.salary_manager.Text + "','0');", myConn);
                MySqlDataReader myReader = AddManager.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Менеджер був доданий до бази");
                clear_my_text_manager();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear_my_text_manager()
        {
            first_name_manager.Clear();
            last_name_manager.Clear();
            city_manager.Clear();
            adress_manager.Clear();
            phone_manager.Clear();
            salary_manager.Clear();
        }

        private void clear_manager_Click_1(object sender, EventArgs e)
        {
            clear_my_text_manager();
        }



        private void list_goods_Click(object sender, EventArgs e)
        {

        }
        //=========================================ПОИСК==============================================
        private void OK_GO_Click(object sender, EventArgs e)
        {
            string[] split_where = comboBox_search_type.SelectedItem.ToString().Split('|');
            string[] split_from = search_mg_combox.SelectedItem.ToString().Split('|');
            dataGridView_search.DataSource = Tests(split_where[1],split_from[1]);
        }

        private DataTable Tests(string where , string from)
        {
            DataTable dt = new DataTable();
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            try
            {
                myConn.Open();
                MySqlCommand mcd = new MySqlCommand("select * from "+ from +" where "+where + "='"+this.search_tb.Text+"';", myConn);
                MySqlDataReader mdr = mcd.ExecuteReader();
                if (mdr.HasRows)
                {
                    dt.Load(mdr);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView_clients.DataSource = GetModel("clients");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            dataGridView_employee.DataSource = GetModel("employee");
        }




        private void submit_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            //    MySqlConnection myConn = new MySqlConnection(myConnection);
            //    myConn.Open();
            //    MySqlCommand AddManager = new MySqlCommand
            //           ("INSERT INTO manager(first_name,last_name, city, adress, phone_number, salary,employee_control) VALUES ('"
            //           + this.first_name_manager.Text + "','"
            //           + this.last_name_manager.Text + "','"
            //           + this.city_manager.Text + "','"
            //           + this.adress_manager.Text + "','"
            //           + this.phone_manager.Text + "','"
            //           + this.salary_manager.Text + "','0');", myConn);
            //    MySqlDataReader myReader = AddManager.ExecuteReader();
            //    myConn.Close();
            //    MessageBox.Show("Оновлено");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void search_mg_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            reload();
        }

        private void search_client_button_Click(object sender, EventArgs e)
        {
            comb_clients.Items.Clear();
            //-------------------------------------------------Инициализация добавление товара
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("select * from clients where last_name LIKE '" + textBox_bukva.Text + "%';", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} | {1} | {2}", mdr.GetString("first_name"), mdr.GetString("last_name"), mdr.GetInt32("client_id"));
                    comb_clients.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void template_c_button_Click(object sender, EventArgs e)
        //{
        //    string[] split_temp = comb_clients.SelectedItem.ToString().Split('|');
        //    comboBox_template.Items.Add("Шановний " + split_temp[0] + split_temp[1] + " вас турбує менеджер компанії ServiceCentreDeLux. Вам потрібно пройти технічне обслуговування кавової машини. Якщо ви це зробили, натисніть так. З повагою компанія ServiceCentreDeLux.");
        //}

        //private void add_to_mail_button_Click(object sender, EventArgs e)
        //{
        //    textArea.Clear();
        //    textArea.AppendText(comboBox_template.SelectedItem.ToString());
        //}

        private void view_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "JPG Files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files (*.*)|*.*";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = opf.FileName.ToString();
                //pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void sent_message_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp = comb_clients.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand modelCount = new MySqlCommand
                 ("UPDATE clients SET status_massage_sent = true WHERE client_id = '" + split_temp[2] + "';", myConn);
                MySqlDataReader myReader2 = modelCount.ExecuteReader();
                myConn.Close();

                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO clients_message(client,message) VALUES ('"+
                split_temp[2]+"','"
                +textArea.Text +"');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffe_marinaDataSet);

        }

        private void output_goods_Click(object sender, EventArgs e)
        {
            modelDataGridView.DataSource = GetModel("model");
        }

        private void textBox_bukva_TextChanged(object sender, EventArgs e)
        {

        }

        private void comb_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split_temp = comb_clients.SelectedItem.ToString().Split('|');
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            //-----------------
            textBox_chat.Clear();
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("Select * from message_mail where client_id = '" + split_temp[2] + "';", myConn);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void reload_t()
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp = comb_clients.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO message_mail(client_id,message, status_message_reade,author) VALUES ('" +
                split_temp[2] + "','"
                + textArea.Text + "', false, 'admin');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp = comb_clients.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO message_mail(client_id,message, status_message_reade,author) VALUES ('" +
                split_temp[2] + "','"
                + textArea.Text + "', false, 'admin');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
                comb_clients_SelectedIndexChanged(sender, e);
                textArea.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void send_message_Click(object sender, EventArgs e)
        {

        }

        private void search_client1_Click(object sender, EventArgs e)
        {
            comb_clients11.Items.Clear();
            //-------------------------------------------------Инициализация добавление товара
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand mcd = new MySqlCommand("select client_id, first_name, last_name from clients where last_name LIKE '" + textBox_bukva1.Text + "%';", myConn);
                myConn.Open();
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    string rows = string.Format("{0} | {1} | {2}", mdr.GetString("first_name"), mdr.GetString("last_name"), mdr.GetInt32("client_id"));
                    comb_clients11.Items.Add(rows);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comb_clients11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split_temp1 = comb_clients11.SelectedItem.ToString().Split('|');
            //string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
        }

        private void comboBox_template_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void sent_message1_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp1 = comb_clients11.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                myConn.Open();
                MySqlCommand modelCount = new MySqlCommand
                 ("UPDATE clients SET status_massage_sent = true WHERE client_id = '" + split_temp1[2] + "';", myConn);
                MySqlDataReader myReader2 = modelCount.ExecuteReader();
                myConn.Close();

                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO clients_message(client,message) VALUES ('" +
                split_temp1[2] + "','"
                + textArea1.Text + "');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void template_c_button1_Click(object sender, EventArgs e)
        {
            string[] split_temp = comb_clients11.SelectedItem.ToString().Split('|');
            comboBox_template1.Items.Add("\t\t\tTO\n                       Шановний(-а) " + split_temp[0] + split_temp[1] + " вас турбує менеджер компанії ServiceCentreDeLux. Вам потрібно пройти технічне обслуговування кавової машини. Якщо ви це зробили, натисніть так. З повагою компанія ServiceCentreDeLux.");
            comboBox_template1.Items.Add("\t\t\tГарантія                     Шановний(-а) " + split_temp[0] + split_temp[1] + " вас турбує менеджер компанії ServiceCentreDeLux. Вам потрібно продовжити гарантію на технічне обслуговування кавової машини. Якщо ви це зробили, натисніть так. З повагою компанія ServiceCentreDeLux.");
        }

        private void add_to_mail_button1_Click(object sender, EventArgs e)
        {
            textArea1.Clear();
            textArea1.AppendText(comboBox_template1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp1 = comb_clients11.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
               

                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO guarantee_mail(client_id,message) VALUES ('" +
                split_temp1[2] + "','"
                + textArea1.Text + "');"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string myConnection = "Database=coffe_marina;Data Source=***;User Id=***;Password=***;Port=***; charset=utf8";
            string[] split_temp1 = comb_clients11.SelectedItem.ToString().Split('|');
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                
                //myConn.Open();
                //MySqlCommand modelCount = new MySqlCommand
                // ("UPDATE clients SET status_massage_guar_read = false WHERE client_id = '" + split_temp1[2] + "';", myConn);
                //MySqlDataReader myReader2 = modelCount.ExecuteReader();
                //myConn.Close();

                myConn.Open();
                MySqlCommand sentmessage = new MySqlCommand
                ("INSERT INTO guarantee_mail(client_id,message, status_message_reade) VALUES ('" +
                split_temp1[2] + "','"
                + textArea1.Text + "',false);"
                , myConn);
                MySqlDataReader myReader3 = sentmessage.ExecuteReader();
                myConn.Close();
                MessageBox.Show("Повідомлення відправлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admin_add_empl_Click(object sender, EventArgs e)
        {

        }

        private void reload_all_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void reload_all_MouseMove(object sender, MouseEventArgs e)
        {
            reload_all.BackColor = Color.PaleGreen;
        }

        private void reload_all_MouseLeave(object sender, EventArgs e)
        {
            reload_all.BackColor = Color.MediumSeaGreen;
        }

        

        private void update_goods_MouseMove(object sender, MouseEventArgs e)
        {
            update_goods.BackColor = Color.Chocolate;
        }

        private void update_goods_MouseLeave(object sender, EventArgs e)
        {
            update_goods.BackColor = Color.SaddleBrown;
        }

        private void comb_clients1_MouseLeave(object sender, EventArgs e)
        {
            comb_clients1.BackColor = Color.SaddleBrown;
        }
        private void comb_clients1_MouseMove(object sender, MouseEventArgs e)
        {
            comb_clients1.BackColor = Color.Chocolate;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Chocolate;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
        }

        private void Add_new_client_MouseMove(object sender, MouseEventArgs e)
        {
            Add_new_client.BackColor = Color.Chocolate;
        }

        private void Add_new_client_MouseLeave(object sender, EventArgs e)
        {
            Add_new_client.BackColor = Color.SaddleBrown;
        }

        private void clear_client_MouseMove(object sender, MouseEventArgs e)
        {
            Add_new_client.BackColor = Color.Chocolate;
        }

        private void clear_client_MouseLeave(object sender, EventArgs e)
        {

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ОШИБКА! Соединение не уставлено!");
            }         
        }

        private void add_MouseMove(object sender, MouseEventArgs e)
        {
            add.BackColor = Color.Chocolate;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = Color.SaddleBrown;
        }

        private void clear_MouseMove(object sender, MouseEventArgs e)
        {
            clear.BackColor = Color.Chocolate;
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Color.SaddleBrown;
        }

        private void OK_GO_MouseMove(object sender, MouseEventArgs e)
        {
            OK_GO.BackColor = Color.Chocolate;
        }

        private void OK_GO_MouseLeave(object sender, EventArgs e)
        {
            OK_GO.BackColor = Color.SaddleBrown;
        }

        private void search_client_button_MouseMove(object sender, MouseEventArgs e)
        {
            search_client_button.BackColor = Color.Chocolate;
        }

        private void search_client_button_MouseLeave(object sender, EventArgs e)
        {
            search_client_button.BackColor = Color.SaddleBrown;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Chocolate;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SaddleBrown;
        }

        private void search_client1_MouseMove(object sender, MouseEventArgs e)
        {
            search_client1.BackColor = Color.Chocolate;
        }

        private void search_client1_MouseLeave(object sender, EventArgs e)
        {
            search_client1.BackColor = Color.SaddleBrown;
        }

        private void template_c_button1_MouseMove(object sender, MouseEventArgs e)
        {
            template_c_button1.BackColor = Color.Chocolate;
        }

        private void template_c_button1_MouseLeave(object sender, EventArgs e)
        {
            template_c_button1.BackColor = Color.SaddleBrown;
        }

        private void add_to_mail_button1_MouseMove(object sender, MouseEventArgs e)
        {
            add_to_mail_button1.BackColor = Color.Chocolate;
        }

        private void add_to_mail_button1_MouseLeave(object sender, EventArgs e)
        {
            add_to_mail_button1.BackColor = Color.SaddleBrown;
        }

        private void sent_message1_MouseMove(object sender, MouseEventArgs e)
        {
            sent_message1.BackColor = Color.Chocolate;
        }

        private void sent_message1_MouseLeave(object sender, EventArgs e)
        {
            sent_message1.BackColor = Color.SaddleBrown;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = Color.Chocolate;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.SaddleBrown;
        }

        //private void submit_MouseMove(object sender, MouseEventArgs e)
        //{
        //    submit.BackColor = Color.Chocolate;
        //}

        //private void submit_MouseLeave(object sender, EventArgs e)
        //{
        //    submit.BackColor = Color.SaddleBrown;
        //}

        private void add_manager_MouseMove(object sender, MouseEventArgs e)
        {
            add_manager.BackColor = Color.Chocolate;
        }

        private void add_manager_MouseLeave(object sender, EventArgs e)
        {
            add_manager.BackColor = Color.SaddleBrown;
        }

        private void clear_manager_MouseMove(object sender, MouseEventArgs e)
        {
            clear_manager.BackColor = Color.Chocolate;
        }

        private void clear_manager_MouseLeave(object sender, EventArgs e)
        {
            clear_manager.BackColor = Color.SaddleBrown;
        }

        private void add_employee_MouseMove(object sender, MouseEventArgs e)
        {
            add_employee.BackColor = Color.Chocolate;
        }

        private void add_employee_MouseLeave(object sender, EventArgs e)
        {
            add_employee.BackColor = Color.SaddleBrown;
        }

        private void clear_employee_MouseMove(object sender, MouseEventArgs e)
        {
            clear_employee.BackColor = Color.Chocolate;
        }

        private void clear_employee_MouseLeave(object sender, EventArgs e)
        {
            clear_employee.BackColor = Color.SaddleBrown;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SaddleBrown;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Chocolate;
        }

        private void view_button_MouseMove(object sender, MouseEventArgs e)
        {
            view_button.BackColor = Color.Chocolate;
        }

        private void view_button_MouseLeave(object sender, EventArgs e)
        {
            view_button.BackColor = Color.SaddleBrown;
        }
    }

}
