namespace Hotel_Management_System
{
    partial class FoodItem
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.quantity1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rate1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.food1_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.quantity2 = new System.Windows.Forms.TextBox();
            this.rate2 = new System.Windows.Forms.TextBox();
            this.food2_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Message1 = new System.Windows.Forms.Label();
            this.Message2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // quantity1
            // 
            this.quantity1.Location = new System.Drawing.Point(109, 231);
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(100, 20);
            this.quantity1.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "QUANTITY";
            // 
            // rate1
            // 
            this.rate1.Location = new System.Drawing.Point(109, 198);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(100, 20);
            this.rate1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "RATE";
            // 
            // food1_id
            // 
            this.food1_id.Location = new System.Drawing.Point(109, 168);
            this.food1_id.Name = "food1_id";
            this.food1_id.Size = new System.Drawing.Size(100, 20);
            this.food1_id.TabIndex = 31;
            this.food1_id.TextChanged += new System.EventHandler(this.food1_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ITEM NAME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(237, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(396, 200);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(785, 296);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(113, 36);
            this.del_btn.TabIndex = 50;
            this.del_btn.Text = "DELETE DATA";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(303, 296);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(81, 36);
            this.back_btn.TabIndex = 52;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(493, 296);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(81, 36);
            this.clear_btn.TabIndex = 51;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.Location = new System.Drawing.Point(657, 296);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(113, 36);
            this.modify_btn.TabIndex = 49;
            this.modify_btn.Text = "MODIFY DATA";
            this.modify_btn.UseVisualStyleBackColor = true;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // quantity2
            // 
            this.quantity2.Location = new System.Drawing.Point(748, 231);
            this.quantity2.Name = "quantity2";
            this.quantity2.Size = new System.Drawing.Size(100, 20);
            this.quantity2.TabIndex = 63;
            // 
            // rate2
            // 
            this.rate2.Location = new System.Drawing.Point(748, 198);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(100, 20);
            this.rate2.TabIndex = 61;
            // 
            // food2_id
            // 
            this.food2_id.Location = new System.Drawing.Point(748, 165);
            this.food2_id.Name = "food2_id";
            this.food2_id.Size = new System.Drawing.Size(100, 20);
            this.food2_id.TabIndex = 57;
            this.food2_id.TextChanged += new System.EventHandler(this.food2_id_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "ITEM NAME";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(109, 296);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(113, 36);
            this.add_btn.TabIndex = 65;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 36);
            this.label13.TabIndex = 66;
            this.label13.Text = "ADD DISHES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(659, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 36);
            this.label14.TabIndex = 67;
            this.label14.Text = "EDIT DISHES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "CATEGORY";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "vegeterian",
            "non_veg",
            "bakery",
            "beverage",
            "desert"});
            this.comboBox1.Location = new System.Drawing.Point(109, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "vegeterian",
            "non_veg",
            "bakery",
            "beverage",
            "desert"});
            this.comboBox2.Location = new System.Drawing.Point(748, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 71;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "CATEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "QUANTITY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "RATE";
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(96, 272);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(0, 13);
            this.Message1.TabIndex = 74;
            // 
            // Message2
            // 
            this.Message2.AutoSize = true;
            this.Message2.Location = new System.Drawing.Point(720, 272);
            this.Message2.Name = "Message2";
            this.Message2.Size = new System.Drawing.Size(0, 13);
            this.Message2.TabIndex = 75;
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 344);
            this.Controls.Add(this.Message2);
            this.Controls.Add(this.Message1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.quantity2);
            this.Controls.Add(this.rate2);
            this.Controls.Add(this.food2_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantity1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rate1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.food1_id);
            this.Controls.Add(this.label1);
            this.Name = "FoodItem";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox quantity1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rate1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox food1_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.TextBox quantity2;
        private System.Windows.Forms.TextBox rate2;
        private System.Windows.Forms.TextBox food2_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Message1;
        private System.Windows.Forms.Label Message2;
    }
}