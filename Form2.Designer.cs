namespace Smart_movers_company
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_error1 = new System.Windows.Forms.Label();
            this.lbl_error_2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_err_3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_state = new System.Windows.Forms.Label();
            this.errorProvider_State = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_State)).BeginInit();
            this.SuspendLayout();
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
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(429, 42);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(722, 30);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(429, 93);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(722, 30);
            this.txt_Name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Type";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(429, 201);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(722, 30);
            this.txt_Address.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_TP
            // 
            this.txt_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TP.Location = new System.Drawing.Point(429, 257);
            this.txt_TP.MaxLength = 10;
            this.txt_TP.Name = "txt_TP";
            this.txt_TP.Size = new System.Drawing.Size(722, 30);
            this.txt_TP.TabIndex = 13;
            this.txt_TP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer TP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.Customer_TP});
            this.dataGridView1.Location = new System.Drawing.Point(219, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 284);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CUSTOMER_ID";
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Width = 125;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "CUSTOMER_NAME";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 200;
            // 
            // Customer_Type
            // 
            this.Customer_Type.DataPropertyName = "CUSTOMER_TYPE";
            this.Customer_Type.HeaderText = "Customer Type";
            this.Customer_Type.MinimumWidth = 6;
            this.Customer_Type.Name = "Customer_Type";
            this.Customer_Type.ReadOnly = true;
            this.Customer_Type.Width = 125;
            // 
            // Customer_Address
            // 
            this.Customer_Address.DataPropertyName = "CUSTOMER_ADDRESS";
            this.Customer_Address.HeaderText = "Customer Address";
            this.Customer_Address.MinimumWidth = 6;
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            this.Customer_Address.Width = 300;
            // 
            // Customer_TP
            // 
            this.Customer_TP.DataPropertyName = "CUSTOMER_TEL_NO";
            this.Customer_TP.HeaderText = "Customer TP";
            this.Customer_TP.MinimumWidth = 6;
            this.Customer_TP.Name = "Customer_TP";
            this.Customer_TP.ReadOnly = true;
            this.Customer_TP.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 43);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Detail";
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
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click_1);
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
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lbl_error1
            // 
            this.lbl_error1.AutoSize = true;
            this.lbl_error1.Location = new System.Drawing.Point(702, 73);
            this.lbl_error1.Name = "lbl_error1";
            this.lbl_error1.Size = new System.Drawing.Size(0, 17);
            this.lbl_error1.TabIndex = 19;
            // 
            // lbl_error_2
            // 
            this.lbl_error_2.AutoSize = true;
            this.lbl_error_2.Location = new System.Drawing.Point(702, 290);
            this.lbl_error_2.Name = "lbl_error_2";
            this.lbl_error_2.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_2.TabIndex = 19;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Category-1",
            "Category-2",
            "Category-3"});
            this.txtType.Location = new System.Drawing.Point(429, 146);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(232, 33);
            this.txtType.TabIndex = 20;
            this.txtType.SelectedIndexChanged += new System.EventHandler(this.txtType_SelectedIndexChanged);
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lbl_err_3
            // 
            this.lbl_err_3.AutoSize = true;
            this.lbl_err_3.Location = new System.Drawing.Point(668, 161);
            this.lbl_err_3.Name = "lbl_err_3";
            this.lbl_err_3.Size = new System.Drawing.Size(0, 17);
            this.lbl_err_3.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lbl_state);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 23;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(17, 545);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(0, 17);
            this.lbl_state.TabIndex = 19;
            // 
            // errorProvider_State
            // 
            this.errorProvider_State.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_err_3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbl_error_2);
            this.Controls.Add(this.lbl_error1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_TP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Customer Detail";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_State)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lbl_error_2;
        private System.Windows.Forms.Label lbl_error1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_TP;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lbl_err_3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.ErrorProvider errorProvider_State;
    }
}