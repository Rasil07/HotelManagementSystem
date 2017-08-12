namespace Hotel_Management_System
{
    partial class add_customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.cust_contact = new System.Windows.Forms.TextBox();
            this.cust_address = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer_id :-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact No :-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address :-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cust_id
            // 
            this.cust_id.Location = new System.Drawing.Point(106, 31);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(100, 20);
            this.cust_id.TabIndex = 4;
            this.cust_id.Click += new System.EventHandler(this.cust_id_Click);
            this.cust_id.TextChanged += new System.EventHandler(this.cust_id_TextChanged);
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(106, 62);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(100, 20);
            this.cust_name.TabIndex = 5;
            this.cust_name.TextChanged += new System.EventHandler(this.cust_name_TextChanged);
            // 
            // cust_contact
            // 
            this.cust_contact.Location = new System.Drawing.Point(106, 92);
            this.cust_contact.Name = "cust_contact";
            this.cust_contact.Size = new System.Drawing.Size(100, 20);
            this.cust_contact.TabIndex = 6;
            this.cust_contact.TextChanged += new System.EventHandler(this.cust_contact_TextChanged);
            // 
            // cust_address
            // 
            this.cust_address.Location = new System.Drawing.Point(106, 127);
            this.cust_address.Name = "cust_address";
            this.cust_address.Size = new System.Drawing.Size(100, 20);
            this.cust_address.TabIndex = 7;
            this.cust_address.TextChanged += new System.EventHandler(this.cust_address_TextChanged);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 235);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(141, 235);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(85, 235);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 10;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // room
            // 
            this.room.Location = new System.Drawing.Point(106, 161);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(100, 20);
            this.room.TabIndex = 8;
            this.room.TextChanged += new System.EventHandler(this.room_TextChanged);
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 346);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cust_address);
            this.Controls.Add(this.cust_contact);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_customer";
            this.Text = "add_customer";
            this.Load += new System.EventHandler(this.add_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.TextBox cust_contact;
        private System.Windows.Forms.TextBox cust_address;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox room;
    }
}