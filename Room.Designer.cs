namespace Hotel_Management_System
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.room_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.cust_address = new System.Windows.Forms.TextBox();
            this.cust_contact = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "CHECKOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // room_no
            // 
            this.room_no.Location = new System.Drawing.Point(113, 158);
            this.room_no.Name = "room_no";
            this.room_no.Size = new System.Drawing.Size(100, 20);
            this.room_no.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Room No";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(92, 232);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 38;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(189, 232);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 39;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // reserve_btn
            // 
            this.reserve_btn.Location = new System.Drawing.Point(14, 232);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(75, 23);
            this.reserve_btn.TabIndex = 37;
            this.reserve_btn.Text = "RESERVE";
            this.reserve_btn.UseVisualStyleBackColor = true;
            this.reserve_btn.Click += new System.EventHandler(this.reserve_btn_Click);
            // 
            // cust_address
            // 
            this.cust_address.Location = new System.Drawing.Point(113, 124);
            this.cust_address.Name = "cust_address";
            this.cust_address.Size = new System.Drawing.Size(100, 20);
            this.cust_address.TabIndex = 35;
            // 
            // cust_contact
            // 
            this.cust_contact.Location = new System.Drawing.Point(113, 89);
            this.cust_contact.Name = "cust_contact";
            this.cust_contact.Size = new System.Drawing.Size(100, 20);
            this.cust_contact.TabIndex = 34;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(113, 59);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(100, 20);
            this.cust_name.TabIndex = 33;
            // 
            // cust_id
            // 
            this.cust_id.Location = new System.Drawing.Point(113, 28);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(100, 20);
            this.cust_id.TabIndex = 32;
            this.cust_id.Click += new System.EventHandler(this.cust_id_Click);
            this.cust_id.TextChanged += new System.EventHandler(this.cust_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Address :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Contact No :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer_id :-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 215);
            this.dataGridView1.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "SEARCH BY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "SEARCH";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(632, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 46;
            this.search.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "room_no",
            "status"});
            this.comboBox1.Location = new System.Drawing.Point(394, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(121, 197);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 48;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 285);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.room_no);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.cust_address);
            this.Controls.Add(this.cust_contact);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox room_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.TextBox cust_address;
        private System.Windows.Forms.TextBox cust_contact;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Message;

    }
}