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
    public partial class sales_data : Form
    {

        DataTable dbdataset;

        MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
        MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public sales_data()
        {
            InitializeComponent();
        }

        private void sales_data_Load(object sender, EventArgs e)
        {
            CreateView();
            DisplayData();
            TotalAmount();
        }

        public void DisplayData()
        {
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from  hotelmanagement.sales;", Con);
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
            Con.Close();
        }

        public void CreateView()
        {

            MySqlCommand command = new MySqlCommand("CREATE VIEW hotelmanagement.sales AS (SELECT * FROM hotelmanagement.sales_data2 WHERE date BETWEEN '" + ParseDate(this.dateFrom.Text) + "' AND '" + ParseDate(this.dateTo.Text) + "' or date between '" + ParseDate(this.dateTo.Text) + "' and '" + ParseDate(this.dateFrom.Text) + "')", Con);
            Con.Open();
            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }

        public void DeleteView()
        {
            MySqlCommand command = new MySqlCommand("Drop view hotelmanagement.sales", Con);
            Con.Open();
            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        public string ParseDate(string getDate)
        {
            string Date = DateTime.Parse(getDate).ToString("yyyy-MM-dd HH:mm:ss");
            return Date;
        }

        public void TotalAmount()
        {
            float total = 0;
            MySqlCommand command = new MySqlCommand("SELECT SUM(total_bill) as Total from hotelmanagement.sales", Con);
            MySqlDataReader myReader;
            Con.Open();

            try
            {
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    total = parseAmount(myReader.GetString("Total"));
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            this.Total.Text = "Rs. " + total + "";
        }

        public float parseAmount(string getPrice)
        {
            float parsed_price = 0;

            try
            {
                parsed_price = (float)Convert.ToDouble(getPrice.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return parsed_price;
        }

        private void dateFrom_ValueChanged_1(object sender, EventArgs e)
        {
            DeleteView();
            CreateView();
            DisplayData();
            TotalAmount();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            DeleteView();
            CreateView();
            DisplayData();
            TotalAmount();
        }

        private void sales_data_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteView();
        }
    }
}
