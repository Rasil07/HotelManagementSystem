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

namespace Hotel_Management_System
{
    public partial class edit_cust : Form
    {
        DataTable dbdataset;
        public edit_cust()
        {
            InitializeComponent();
            up_database();
            del_database();
            AutoCompleteText_cust_id();
            AutoCompleteText_cust_name();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("" + this.comboBox1.Text + " LIKE  '{0}%'", search.Text);
            dataGridView1.DataSource = DV;
        }

        private void edit_cust_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.customer;", Con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void AutoCompleteText_cust_id()
        {

            cust_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cust_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM hotelmanagement.customer;", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("cust_id");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            cust_id.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        void AutoCompleteText_cust_name()
        {

            cust_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cust_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM hotelmanagement.customer;", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("customer_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            cust_name.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer fm = new Customer();
            fm.Show();

        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement.customer where cust_id = " + this.cust_id.Text + ";";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.cust_name.Text = myReader.GetString("customer_name");
                    this.cust_contact.Text = myReader.GetString("cust_contact");
                    this.cust_address.Text = myReader.GetString("cust_address");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cust_name_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("customer_name LIKE  '{0}%'", cust_name.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement.customer where customer_name = '" + this.cust_name.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.cust_id.Text = myReader.GetString("cust_id");
                    this.cust_contact.Text = myReader.GetString("cust_contact");
                    this.cust_address.Text = myReader.GetString("cust_address");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);

            
            string query = "UPDATE hotelmanagement.customer SET customer_name = '" + this.cust_name.Text + "', cust_contact = '" + this.cust_contact.Text + "', cust_address = '" + this.cust_address.Text + "'  where cust_id = " + this.cust_id.Text + "";

            MySqlCommand command = new MySqlCommand(query, Con);
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.Message.Text = "UPDATE SUCCESS!!";
                up_database();



            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
        public void up_database()
        {

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.customer;", Con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            string query = "DELETE FROM hotelmanagement.customer where cust_id = " + this.cust_id.Text + "; ";

            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlCommand delete_staff = new MySqlCommand("DELETE FROM hotelmanagement.customer where cust_id = " + this.cust_id.Text + ";", Con);


            MySqlDataReader myReader;

            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            try
            {
                Con.Open();
                delete_staff.ExecuteNonQuery();
                this.Message.Text = "DELETE SUCCESSFUL";
                del_database();
                
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            Con.Close();
            
           
        }
        public void del_database()
        {

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.customer;", Con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
