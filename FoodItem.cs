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
    public partial class FoodItem : Form
    {
        DataTable dbdataset;
        public FoodItem()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu fm = new Menu();
            fm.Show();

        }

      

        private void food1_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("INSERT INTO hotelmanagement." + this.comboBox1.Text + " values('" + this.food1_id.Text + "'," + this.rate1.Text + ", '" + this.quantity1.Text + "');", Con);

            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                LoadData1();
                count = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();

            this.comboBox1.Text = "none";
            this.food1_id.Text = "";
            this.rate1.Text = "";
            this.quantity1.Text = "";
            
            if (count == 1)
            {
                this.Message1.Text = "Dish Addition Success!!";
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu fm = new Menu();
            fm.Show();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = "none";
            this.comboBox2.Text = "none";
            this.food1_id.Text = "";
            this.food2_id.Text = "";
            this.rate1.Text = "";
            this.rate2.Text = "";
            this.quantity1.Text = "";
            this.quantity2.Text = "";
        }
        public void LoadData1()
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement."+this.comboBox1.Text+";", Con);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData2();
            AutoCompleteText();
        }

        public void LoadData2()
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement." + this.comboBox2.Text + ";", Con);

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
        void AutoCompleteText()
        {

            food2_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            food2_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            // this code is for reading data from column item_name of table selected and saving it to string collection named "coll"

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("SELECT * FROM hotelmanagement." + this.comboBox2.Text + ";", Con);
            MySqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = command.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("item_name");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            food2_id.AutoCompleteCustomSource = coll;       //loading coll to the customsource

        }

      


        private void food2_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", food2_id.Text);
            

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement."+ this.comboBox2.Text +" where item_name = '" + this.food2_id.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.rate2.Text = myReader.GetString("rate");
                    this.quantity2.Text = myReader.GetString("stock");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            string query = "";

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlDataReader myReader;
            int new_quantity = 0;
            float new_price = 0;

            if (this.quantity2.Text != "" && this.rate2.Text != "")
            {
                new_quantity = parse_quant(this.quantity2.Text);
                new_price = parse_price(this.rate2.Text);
                query = "UPDATE hotelmanagement." + this.comboBox2.Text + " SET stock = stock + " + new_quantity + ", rate = " + new_price + " where item_name = '" + this.food2_id.Text + "'";
                this.Message2.Text = "Price and Quantity UPDATED!!";
            }
            else if (this.quantity2.Text == "" && this.rate2.Text == "")
            {
                MessageBox.Show("Enter Details!", "Please provide Quantity or Price to Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                query = "";
            }
            else if (this.quantity2.Text != "")
            {
                new_quantity = parse_quant(this.quantity2.Text);
                query = "UPDATE hotelmanagement." + this.comboBox2.Text + " SET stock = stock + " + new_quantity + " where item_name = '" + this.food2_id.Text + "'";
                this.Message2.Text = "Quantity UPDATED!!";
            }
            else if (this.rate2.Text != "")
            {
                new_price = parse_price(this.rate2.Text);
                query = "UPDATE hotelmanagement." + this.comboBox2.Text + " SET rate = " + new_price + " where item_name = '" + this.food2_id.Text + "'";
                this.Message2.Text = "Price UPDATED!!";
            }

            MySqlCommand command = new MySqlCommand(query, Con);

            try
            {
                Con.Open();
                myReader = command.ExecuteReader();
                LoadData2();
                //this.status.Text = new_price.ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            Con.Close();
            
            this.food2_id.Text = "";
            this.rate2.Text = "";
            this.quantity2.Text = "";
          }


        int parse_quant(string quant)
        {
            int new_quantity = 0;
            try
            {
                new_quantity = (int)Convert.ToInt32(quant.Trim());
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new_quantity;
        }

        float parse_price(string getPrice)
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

        private void del_btn_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();


            string query = "DELETE FROM hotelmanagement." + this.comboBox2.Text + " where item_name = '" + this.food2_id.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            
            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                LoadData2();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            this.rate2.Text = "";
            this.quantity2.Text = "";
            this.Message2.Text = "DISH DELETED!!";
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            this.Message1.Text = "";
            this.Message2.Text = "";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.Message1.Text = "";
            this.Message2.Text = "";
        }

    }
}
