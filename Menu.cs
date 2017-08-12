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
    public partial class Menu : Form
    {
        string staffid;
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodItem fm = new FoodItem();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }



        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login fm = new Login();
            fm.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer fm = new Customer();
            fm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Room fm1 = new Room();
            fm1.Show();
        }

        private void staffmenustrip_Click(object sender, EventArgs e)
        {

        }

        private void eDITSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            edit_staff fm = new edit_staff();
            fm.Show();
        }

        private void aDDSTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            add_staff fm1 = new add_staff();
            fm1.Show();
        }

        private void normalBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            customer_billing fm3 = new customer_billing();
            fm3.Show();
        }

       

        private void saleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            sales_data fm5 = new sales_data();
            fm5.Show();
        }

        private void cHECKOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            checkout fm4 = new checkout();
            fm4.Show();
        }
    }
}
