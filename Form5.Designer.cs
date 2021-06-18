namespace Smart_movers_company
{
    partial class Form5
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
            this.lbl_error_2 = new System.Windows.Forms.Label();
            this.lbl_error1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Load_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_error_2
            // 
            this.lbl_error_2.AutoSize = true;
            this.lbl_error_2.Location = new System.Drawing.Point(747, 319);
            this.lbl_error_2.Name = "lbl_error_2";
            this.lbl_error_2.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_2.TabIndex = 92;
            // 
            // lbl_error1
            // 
            this.lbl_error1.AutoSize = true;
            this.lbl_error1.Location = new System.Drawing.Point(747, 102);
            this.lbl_error1.Name = "lbl_error1";
            this.lbl_error1.Size = new System.Drawing.Size(0, 17);
            this.lbl_error1.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PanRoman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(570, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 34);
            this.label6.TabIndex = 87;
            this.label6.Text = "Transport Detail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Customer_Name,
            this.Customer_Type,
            this.Customer_Address,
            this.Customer_TP,
            this.Load_ID,
            this.Job_ID});
            this.dataGridView1.Location = new System.Drawing.Point(254, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 272);
            this.dataGridView1.TabIndex = 86;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CUSTOMER_ID";
            this.Customer_ID.HeaderText = "Vehicle ID";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Width = 125;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "CUSTOMER_NAME";
            this.Customer_Name.HeaderText = "Start Location";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 125;
            // 
            // Customer_Type
            // 
            this.Customer_Type.DataPropertyName = "CUSTOMER_TYPE";
            this.Customer_Type.HeaderText = "End Location";
            this.Customer_Type.MinimumWidth = 6;
            this.Customer_Type.Name = "Customer_Type";
            this.Customer_Type.ReadOnly = true;
            this.Customer_Type.Width = 125;
            // 
            // Customer_Address
            // 
            this.Customer_Address.DataPropertyName = "CUSTOMER_ADDRESS";
            this.Customer_Address.HeaderText = "Unit ID";
            this.Customer_Address.MinimumWidth = 6;
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            this.Customer_Address.Width = 125;
            // 
            // Customer_TP
            // 
            this.Customer_TP.DataPropertyName = "CUSTOMER_TEL_NO";
            this.Customer_TP.HeaderText = "Driving ID";
            this.Customer_TP.MinimumWidth = 6;
            this.Customer_TP.Name = "Customer_TP";
            this.Customer_TP.ReadOnly = true;
            this.Customer_TP.Width = 125;
            // 
            // Load_ID
            // 
            this.Load_ID.HeaderText = "Assign ID";
            this.Load_ID.MinimumWidth = 6;
            this.Load_ID.Name = "Load_ID";
            this.Load_ID.ReadOnly = true;
            this.Load_ID.Width = 125;
            // 
            // Job_ID
            // 
            this.Job_ID.HeaderText = "Conductor ID";
            this.Job_ID.MinimumWidth = 6;
            this.Job_ID.Name = "Job_ID";
            this.Job_ID.ReadOnly = true;
            this.Job_ID.Width = 125;
            // 
            // txt_TP
            // 
            this.txt_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TP.Location = new System.Drawing.Point(474, 286);
            this.txt_TP.MaxLength = 10;
            this.txt_TP.Name = "txt_TP";
            this.txt_TP.Size = new System.Drawing.Size(281, 30);
            this.txt_TP.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(345, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Driving ID";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(474, 230);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(281, 30);
            this.txt_Address.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(373, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Unit ID";
            // 
            // txt_Type
            // 
            this.txt_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Type.Location = new System.Drawing.Point(474, 178);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(281, 30);
            this.txt_Type.TabIndex = 79;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(901, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 30);
            this.textBox2.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(317, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = " End Location";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(474, 122);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(281, 30);
            this.txt_Name.TabIndex = 76;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(901, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 30);
            this.textBox1.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(312, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Start Location";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(474, 71);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(281, 30);
            this.txt_ID.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(764, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Conductor ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(800, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Assign ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PanRoman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(348, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Vehicle ID";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("PanRoman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_back.Location = new System.Drawing.Point(0, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(200, 39);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(0, 60);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(200, 36);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(0, 102);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Update.Size = new System.Drawing.Size(200, 36);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(0, 144);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Delete.Size = new System.Drawing.Size(200, 37);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(0, 187);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Clear.Size = new System.Drawing.Size(200, 37);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 637);
            this.panel1.TabIndex = 93;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_error_2);
            this.Controls.Add(this.lbl_error1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Transport";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_error_2;
        private System.Windows.Forms.Label lbl_error1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_ID;
        private System.Windows.Forms.TextBox txt_TP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
    }
}