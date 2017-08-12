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
    public partial class customer_billing : Form
    {
        DataTable dbdataset;
        string product_name;
        Boolean check = false;
        MySqlCommand command;                                                                                         //for sql connection
        MySqlDataAdapter adapt;
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public customer_billing()
        {
            InitializeComponent();
        }

        void AutoCompleteText()
        {

            item_name_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            item_name_txt.AutoCompleteCustomSource = coll;       //loading coll to the customsource

        }

        private void item_name_txt_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("item_name LIKE  '{0}%'", item_name_txt.Text);


            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement." + this.comboBox2.Text + " where item_name = '" + this.item_name_txt.Text + "';";
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    this.unit_price_txt.Text = myReader.GetString("rate");
                    this.available_quantity_txt.Text = myReader.GetString("stock");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        void ClearData()
        {
            this.item_name_txt.Text = "";
            this.salequantity_txt.Text = "";
            this.unit_price_txt.Text = "";
            this.available_quantity_txt.Text = "";
            this.totalamount_txt.Text = "";
            product_name = "";
        }
        void ClearAllData()
        {
           
            this.cust_id_txt.Text = "";
           
            this.GrandTotal_txt.Text = "";
            ClearData();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
           
            AutoCompleteText();
        }

     

        private void addtocart_button_Click(object sender, EventArgs e)
        {
            check = true;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "INSERT INTO hotelmanagement.cart values('" + this.item_name_txt.Text + "'," + this.salequantity_txt.Text + "," + this.totalamount_txt.Text + ");";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);

            try
            {
                Con.Open();
                command.ExecuteNonQuery();
                this.info_txt.Text = "Added to Cart Successfully!!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();
            DisplayCartData();
            ClearData();  
        }


        void DisplayCartData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM hotelmanagement.cart", connection);
            adapt.Fill(dt);
            dataGridCart.DataSource = dt;
            connection.Close();
        }
        private void salequantity_txt_TextChanged(object sender, EventArgs e)
        {
            float item_price = 0;     //this is the product of unit price and the quantity
            float parsed_unit_price = parse_price(this.unit_price_txt.Text);
            int parsed_sale_quantity = parse_quant(this.salequantity_txt.Text);
            item_price = parsed_unit_price * parsed_sale_quantity;
            this.totalamount_txt.Text = item_price.ToString();
        }

       
        void AutoCompleteText_CustId()
        {
            cust_id_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            cust_id_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            cust_id_txt.AutoCompleteCustomSource = coll;       //loading coll to the customsource
        }


        //private void cust_id_txt_TextChanged(object sender, EventArgs e)
        //{
           
        //    DataView DV = new DataView(dbdataset);
        //    //DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id_txt.Text);

        //    string myconn = "datasource=localhost;port=3306;username=root;password=";
        //    string query = "SELECT * FROM department_store.customer where cust_id = '" + this.cust_id_txt.Text + "';";
        //    MySqlConnection Con = new MySqlConnection(myconn);
        //    MySqlCommand command = new MySqlCommand(query, Con);
        //    MySqlDataReader myReader;
        //    try
        //    {
        //        Con.Open();
        //        myReader = command.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            this.customerName_txt.Text = myReader.GetString("customer_name");
        //            this.phone_num_txt.Text = myReader.GetString("phone_number");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        private void customer_billing_Load(object sender, EventArgs e)
        {
           // this.discount_label.Visible = false;
            AutoCompleteText_CustId();
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement." + this.comboBox2.Text + ";", Con);
            Con.Open();
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

            this.date_text.Text = DateTime.Now.ToString("yyyy/MM/dd");


            MySqlCommand com1 = new MySqlCommand("select * from hotelmanagement.sales_data2 where bill_id = (select MAX(bill_id) from hotelmanagement.sales_data2) ;", Con);
            MySqlDataReader myReader;
            string string_bill_id = "";
            try
            {
                myReader = com1.ExecuteReader();
                while (myReader.Read())
                {
                    string_bill_id = myReader.GetString("bill_id");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int bill_id = 0;
            bill_id = parse_quant(string_bill_id);
            bill_id += 1;
            this.bill_num_txt.Text = bill_id.ToString();
            DisplayCartData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand("UPDATE hotelmanagement.cart set quantity=@quantity ,total_cost = @amount where item_name=@name", connection);
            connection.Open();
            command.Parameters.AddWithValue("@name", product_name);
            command.Parameters.AddWithValue("@quantity", salequantity_txt.Text);
            command.Parameters.AddWithValue("@amount", totalamount_txt.Text);
            try
            {
                command.ExecuteNonQuery();
                this.info_txt.Text = "Cart Update Successful!!!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            DisplayCartData();
            this.addtocart_button.Enabled = true;
            ClearData(); 
        }

        private void dataGridCart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product_name = dataGridCart.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.item_name_txt.Text = product_name;
            this.salequantity_txt.Text = dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.totalamount_txt.Text = dataGridCart.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.addtocart_button.Enabled = false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand com = new MySqlCommand("select * from hotelmanagement.cart;", Con);
            MySqlDataReader myReader;
            string amount = "";
            float grand_total = 0;
            Con.Open();
            try
            {
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    amount = myReader.GetString("total_cost");
                   
                        grand_total += parse_price(amount);
                        grand_total = grand_total + (grand_total * (float)0.10);
                    }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            this.GrandTotal_txt.Text = grand_total.ToString();
        }
        public void delete_from_cart()
        {
            string query = "DELETE FROM hotelmanagement.cart ;";
            command = new MySqlCommand(query, connection);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            DisplayCartData();
            ClearAllData();

        }


        public int get_number_ofdata_cart()
        {
            MySqlCommand com = new MySqlCommand("select item_name, quantity from hotelmanagement.cart", connection);
            MySqlDataReader myReader;
            int count = 0;
            try
            {
                connection.Open();
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    count += 1;

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            return count;
        }
        public void read_from_cart()
        {
            MySqlCommand com = new MySqlCommand("select * from hotelmanagement.cart", connection);
            MySqlDataReader myReader;
            int data_number = get_number_ofdata_cart();
            string[] item_name_array = new string[data_number];
            string[] quantity_array = new string[data_number];
            string[] table_name_array = new string[data_number];
            int i = 0;
            try
            {
                connection.Open();
                myReader = com.ExecuteReader();
                while (myReader.Read())
                {
                    item_name_array[i] = myReader.GetString("item_name");
                    quantity_array[i] = myReader.GetString("quantity");
                    table_name_array[i] = myReader.GetString("category");
                    i += 1;

                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            for (int j = 0; j < data_number; j++)
            {
                quantity_decrease(table_name_array[j], item_name_array[j], quantity_array[j]);
            }

        }

        private void quantity_decrease(string table_name, string item_name_cart, string quantity_added_cart)
        {
            connection.Open();
            MySqlCommand com = new MySqlCommand("UPDATE hotelmanagement." + table_name + " SET stock = stock-" + parse_quant(quantity_added_cart) + " where item_name = '" + item_name_cart + "' ", connection);
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            check = false;
            MySqlCommand command1;
            string query1 = "";
            string query2 = "";
            string timestamp = DateTime.Today.ToString("yyyy/MM/dd");
           

                query1 = "INSERT INTO hotelmanagement.sales_data2 (total_bill,cust_id,date) values (" + this.GrandTotal_txt.Text + ",'" + this.cust_id_txt.Text + "','" + timestamp + "' );";
                query2 = "INSERT INTO hotelmanagement.customer (cust_id,total_bill) values (" + this.cust_id_txt.Text + "," + this.GrandTotal_txt.Text + ");";
               
           
            command1 = new MySqlCommand(query2, connection);
            command = new MySqlCommand(query1, connection);
                connection.Open();

                try
                {

                    command1.ExecuteNonQuery();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            
          


            connection.Close();
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand com1 = new MySqlCommand("select * from hotelmanagement.sales_data2 where bill_id = (select MAX(bill_id) from hotelmanagement.sales_data2) ;", Con);
            MySqlDataReader myReader;
            string string_bill_no = "";
            Con.Open();
            try
            {

                myReader = com1.ExecuteReader();
                while (myReader.Read())
                {
                    string_bill_no = myReader.GetString("bill_id");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            int bill_no = 0;
            bill_no = parse_quant(string_bill_no);
            bill_no += 1;
            this.bill_num_txt.Text = bill_no.ToString();
            read_from_cart();
            delete_from_cart();
            DisplayCartData();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (check)
            {
                DialogResult result = MessageBox.Show("New Bill Without Saving?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    delete_from_cart();

                }
            }
        }

        private void item_name_txt_MouseClick(object sender, MouseEventArgs e)
        {
            this.info_txt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllData();
            delete_from_cart();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {            order fm = new order();
            fm.Show();
        }
    }
}
