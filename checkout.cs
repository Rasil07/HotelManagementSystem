using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class checkout : Form
    {
        DataTable dbdataset;
        public checkout()
        {
            InitializeComponent();
        }

        public int parse_cust(string sal)
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

        private void cust_id_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
           // DV.RowFilter = string.Format("cust_id LIKE  '{0}%'", cust_id.Text);
            DV.RowFilter = String.Format(CultureInfo.InvariantCulture.NumberFormat, "cust_id={0}", parse_cust(cust_id.Text));

            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query = "SELECT * FROM hotelmanagement.customer where cust_id = '" + this.cust_id.Text + "';";
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
                    this.room_resv.Text = myReader.GetString("room_reserved");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            MySqlConnection Con = new MySqlConnection(myconn);
            MySqlCommand cmd = new MySqlCommand("select * from hotelmanagement.customer where room_reserved != '';", Con);

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

        public void ClearData(){

            this.cust_id.Text = "";
            this.cust_name.Text = "";
            this.cust_address.Text = "";
            this.cust_contact.Text = "";
            this.room_resv.Text = "";
  


        }
        public static long parse_toint(DateTime value)
        {
            return long.Parse(value.ToString("yyyyMMddHHmmss"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myconn = "datasource=localhost;port=3306;username=root;password=";
            string query1 = "";
            string query = "";
            long date_diff = 0;
            long day = 0;
            MySqlDataReader myReader;
            MySqlConnection Con = new MySqlConnection(myconn);
           
            DateTime checked_in ,checked_out_data;
            string date_check="";
            string checked_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
           // MessageBox.Show(checked_out);
            string query2 = "SELECT * FROM hotelmanagement.customer where cust_id="+this.cust_id.Text+"";
            MySqlCommand command2 = new MySqlCommand(query2, Con);
            try
            {
                Con.Open();
                myReader = command2.ExecuteReader();
                while(myReader.Read())
                {
                    date_check = myReader.GetString("checkedout_time");


                    MessageBox.Show(date_check.ToString());
                }
                if (date_check != "")
                {
                    this.label4.Text = "Already Checked out";
                    ClearData();
                    
                }
                else
                {
                   
                    query = "UPDATE hotelmanagement.customer  SET checkedout_time = '" + checked_out + "' where cust_id = " + this.cust_id.Text + ";";
                    query1 = "SELECT * FROM hotelmanagement.customer where cust_id = '" + this.cust_id.Text + "';";
                    MySqlCommand command = new MySqlCommand(query, Con);
                    MySqlCommand command1 = new MySqlCommand(query1, Con);
                    try
                    {


                        myReader = command1.ExecuteReader();
                        while (myReader.Read())
                        {
                            checked_in = myReader.GetDateTime("checked_intime");
                            checked_out_data = myReader.GetDateTime("checkedout_time");
                            // long result = long.Parse(checked_out_data.ToString("yyyyMMddHHmmss"));
                            //  MessageBox.Show(result.ToString());


                            //MessageBox.Show(checked_out_data);
                            //MessageBox.Show(parse_cust(checked_out_data).ToString());
                            date_diff = parse_toint(checked_out_data) - parse_toint(checked_in);
                            day = date_diff / (24 * 60 * 60);

                            //  MessageBox.Show(date_diff.ToString());
                            MessageBox.Show(day.ToString());

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Con.Close();
                    // MessageBox.Show(date_diff.ToString());
                    calculate_total(day);
                }

               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }
         public void calculate_total(float day){

             string myconn = "datasource=localhost;port=3306;username=root;password=";
             MySqlDataReader myReader;
             MySqlConnection Con = new MySqlConnection(myconn);
             float price=0;
             float amount_of_room;
             
             string query1 = "";
             string query = "";
             query = "Select * FROM hotelmanagement.room where room_no='" + this.room_resv.Text + "'";
             
             MySqlCommand command = new MySqlCommand(query, Con);
             
             try
             {
                 Con.Open();
                 myReader = command.ExecuteReader();
                 while (myReader.Read())
                 {
                     price = myReader.GetFloat("price");
                     MessageBox.Show(price.ToString());

                 }

             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             Con.Close();
            amount_of_room = day * price;
             query1 = "UPDATE hotelmanagement.room SET status = 'available', cust_id = '' where room_no = '" + this.room_resv.Text + "'";
            
             string query2 = "UPDATE hotelmanagement.customer SET room_reserved='', total_bill=total_bill+" + amount_of_room + "  where room_reserved='" + this.room_resv.Text + "'&& cust_id=" + this.cust_id.Text + "";
             MySqlCommand command1 = new MySqlCommand(query1, Con);
             MySqlCommand command2 = new MySqlCommand(query2, Con);


             try
             {
                 Con.Open();
                 command1.ExecuteNonQuery();
                 command2.ExecuteNonQuery();
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             Con.Close();

             string query3 = "SELECT * FROM hotelmanagement.customer";
             MySqlCommand command3 = new MySqlCommand(query3, Con);
             float grand_total =0;

             try
             {
                 Con.Open();
                 myReader = command3.ExecuteReader();
                 while (myReader.Read())
                 {
                     grand_total = myReader.GetFloat("total_bill");
                 }
                 
                 this.label1.Text = "RS. "+grand_total.ToString()+"";
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             Con.Close();
            
             ClearData();

             
         }

         private void cust_id_MouseClick(object sender, MouseEventArgs e)
         {
             ClearData();
         }

         private void button2_Click(object sender, EventArgs e)
         {
             this.Close();
             Menu fm = new Menu();
             fm.Show();
         }  
    }
}
