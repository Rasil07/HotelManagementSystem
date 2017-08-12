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
    public partial class add_customer : Form
    {
        
        public add_customer()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            string checked_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand("INSERT INTO hotelmanagement.customer(cust_id,customer_name,cust_contact,cust_address,room_reserved,checked_intime) values(" + this.cust_id.Text + ",'" + this.cust_name.Text + "', '" + this.cust_contact.Text + "','" + this.cust_address.Text + "','" + this.room.Text + "','" + checked_in + "');", Con);

            try
            {
                Con.Open();
                command.ExecuteNonQuery();
              
                count = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Con.Close();


            this.cust_id.Text = "";
            this.cust_name.Text = "";
            this.cust_contact.Text = "";
            this.cust_address.Text = "";
            if (count == 1)
            {
                this.status.Text = "Item Addition Success!!";
            }
        }
      
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer fm = new Customer();
            fm.Show();
        }

        private void cust_id_Click(object sender, EventArgs e)
        {
            this.status.Text = "";
        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void cust_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void add_customer_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand com1 = new MySqlCommand("select * from hotelmanagement.customer where cust_id = (select MAX(cust_id) from hotelmanagement.customer) ;", Con);
            MySqlDataReader myReader;
            string string_cust_id = "";
            try
            {
                Con.Open();
                myReader = com1.ExecuteReader();
                while (myReader.Read())
                {
                    string_cust_id = myReader.GetString("cust_id");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            int cust_id = 0;
            cust_id = parse_quant(string_cust_id);
            cust_id += 1;
            this.cust_id.Text = cust_id.ToString();
        }
    }
}
