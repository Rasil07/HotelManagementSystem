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
    public partial class edit_staff : Form
    {
        DataTable dbdataset;
        public edit_staff()
        {
            InitializeComponent();
        }

        private void SearchStaff_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("" + this.comboBox1.Text + " LIKE  '{0}%'", SearchStaff.Text);
            dataGridView1.DataSource = DV;
        }

        private void edit_staff_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.staff;", Con);

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

        private void staff_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("staff_id LIKE  '{0}%'", staff_id.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement.staff where staff_id = '" + this.staff_id.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.staff_name.Text = myReader.GetString("staff_name");
                    this.designation.Text = myReader.GetString("Designation");
                    this.phone_number.Text = myReader.GetString("phone_num");
                    this.address.Text = myReader.GetString("address");
                    this.salary.Text = myReader.GetString("salary");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.designation.Text = "";
            this.phone_number.Text = "";
            this.address.Text = "";
            this.salary.Text = "";

        }
        public int parseSalary(string sal)
        {
            int salary = 0;
            try
            {
                salary = (int)Convert.ToInt32(sal.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return salary;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu fm = new Menu();
            fm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string position = "";
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            int salary = parseSalary(this.salary.Text);
            string query = "SELECT * FROM hotelmanagement.staff where staff_id = '" + this.staff_id.Text + "';";
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();


                while (myReader.Read())
                {
                    position = myReader.GetString("Designation").ToLower();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            if (position == "manager")
            {
                this.Message.Text = "Manager Cannot be Removed ";
            }
            else
            {
                //USING ON DELETE CASCADE
                MySqlCommand delete_staff = new MySqlCommand("DELETE FROM hotelmanagement.staff where staff_id = '" + this.staff_id.Text + "';", Con);
                try
                {
                    Con.Open();
                    delete_staff.ExecuteNonQuery();
                    LoadData();
                    this.Message.Text = "STAFF DELETED!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        public void LoadData()
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.staff;", Con);

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

        private void button1_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            int salary = parseSalary(this.salary.Text);
            string query = "UPDATE hotelmanagement.staff SET staff_name = '" + this.staff_name.Text + "', Designation = '" + this.designation.Text + "', phone_num = '" + this.phone_number.Text + "', address = '" + this.address.Text + "', salary = " + salary + " where staff_id = '" + this.staff_id.Text + "'";

            MySqlCommand command = new MySqlCommand(query, Con);
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.Message.Text = "UPDATE SUCCESS!!";

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
