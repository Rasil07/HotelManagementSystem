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
    public partial class Room : Form
    {
        DataTable dbdataset;
        public Room()
        {
            InitializeComponent();
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            string status_check="";
            string query = "SELECT * FROM hotelmanagement.room where room_no = '" + this.room_no.Text + "';";
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlDataReader myReader;
            try
            {
                Con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                   status_check = myReader.GetString("status").ToLower();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();

            if(status_check=="booked"){
                this.Message.Text = "Room already reserved!!";
            }
            else
            {

                string checked_out = "";
                string checked_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                MySqlCommand command1 = new MySqlCommand("INSERT INTO hotelmanagement.customer values('" + this.cust_id.Text + "','" + this.cust_name.Text + "', '" + this.cust_contact.Text + "','" + this.cust_address.Text + "','" + this.room_no.Text + "','" + checked_in + "','" + checked_out + "');", Con);
                string query2 = "UPDATE hotelmanagement.room SET status = 'booked', cust_id = '"+this.cust_id.Text+"' where room_no = '" + this.room_no.Text + "'";

                MySqlCommand command2 = new MySqlCommand(query2, Con); 

                try 
                {
                    Con.Open();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    LoadData();
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
                this.room_no.Text = "";
                if (count == 1)
                {
                    this.Message.Text = "Room Reserved!!";
                }

            }
           


        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("" + this.comboBox1.Text + " LIKE  '{0}%'", search.Text);
            dataGridView1.DataSource = DV;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.room;", Con);

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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu fm = new Menu();
            fm.Show();
        }

        public void LoadData()
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.room;", Con);

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
            string checked_out =DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            string query1 =  "UPDATE hotelmanagement.room SET status = 'available', cust_id = '' where room_no = '" + this.room_no.Text + "'";
            string query2 = "UPDATE hotelmanagement.customer SET checkedout_time = '"+checked_out+"' where cust_id = '"+this.cust_id.Text+"'";

            MySqlCommand command1 = new MySqlCommand(query2, Con);
            MySqlCommand command = new MySqlCommand(query1, Con);

                    try
            {
                Con.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                this.Message.Text = "CHECKOUT SUCCESS!!";
                LoadData();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            Con.Close();
        }

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id.Text);

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement.customer where cust_id = '" + this.cust_id.Text + "';";
            string query1 = "SELECT * FROM hotelmanagement.room where cust_id = '" + this.cust_id.Text + "';";

            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand command = new MySqlCommand(query, Con);
            MySqlCommand command1 = new MySqlCommand(query1, Con);

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
           Con.Close();
           try
           {
               Con.Open();
               myReader = command1.ExecuteReader();

               while (myReader.Read())
               {
                   
                   this.room_no.Text = myReader.GetString("room_no");

               }

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
           Con.Close();
        }

        private void cust_id_Click(object sender, EventArgs e)
        {
            this.cust_id.Text = "";
            this.cust_name.Text = "";
            this.cust_contact.Text = "";
            this.cust_address.Text = "";
            this.room_no.Text = "";
        }
        
            
        }
    }

