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
    public partial class add_staff : Form
    {
        DataTable dbdataset;
        public add_staff()
        {
            InitializeComponent();
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
           
            
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("INSERT INTO hotelmanagement.staff values('" + this.staff_id.Text + "','" + this.staff_name.Text + "', '" + this.designation.Text + "','" + this.staff_contact.Text + "','" + this.staff_address.Text + "','" + this.staff_salary.Text+ "');", Con);

            try
            {
                Con.Open();
                
                command.ExecuteNonQuery();
                LoadData();
               
                count = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();


            this.staff_id.Text = "";
            this.staff_name.Text = "";
            this.staff_contact.Text = "";
            this.staff_address.Text = "";
            this.designation.Text = "";
            this.staff_salary.Text = "";
            if (count == 1)
            {
                this.status.Text = "STAFF Addition Success!!";
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

        private void add_staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu fm = new Menu();
            fm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
