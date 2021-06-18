namespace Smart_movers_company
{
    partial class Frm_welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_welcome));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_err = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnlogout = new System.Windows.Forms.Button();
            this.ch_Visible = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DASHBOARD = new System.Windows.Forms.Button();
            this.SYSTEM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(200, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "USER_NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.label4.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(199, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "PASSWORD";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(210, 149);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(248, 30);
            this.txt_password.TabIndex = 13;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(210, 63);
            this.txt_user.MaxLength = 10;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(248, 30);
            this.txt_user.TabIndex = 13;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(-2, 152);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 27);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.lbl_err.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_err.Location = new System.Drawing.Point(15, 58);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(0, 17);
            this.lbl_err.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Location = new System.Drawing.Point(-2, 348);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(200, 29);
            this.btnlogout.TabIndex = 16;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // ch_Visible
            // 
            this.ch_Visible.AutoSize = true;
            this.ch_Visible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ch_Visible.BackgroundImage")));
            this.ch_Visible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ch_Visible.Location = new System.Drawing.Point(402, 155);
            this.ch_Visible.MinimumSize = new System.Drawing.Size(50, 20);
            this.ch_Visible.Name = "ch_Visible";
            this.ch_Visible.Size = new System.Drawing.Size(50, 20);
            this.ch_Visible.TabIndex = 17;
            this.ch_Visible.UseVisualStyleBackColor = true;
            this.ch_Visible.CheckedChanged += new System.EventHandler(this.ch_Visible_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(207, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 188);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(231, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Author - Bavanthini Uthayakumar";
            // 
            // DASHBOARD
            // 
            this.DASHBOARD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.DASHBOARD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DASHBOARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DASHBOARD.Location = new System.Drawing.Point(-2, 247);
            this.DASHBOARD.Name = "DASHBOARD";
            this.DASHBOARD.Size = new System.Drawing.Size(200, 29);
            this.DASHBOARD.TabIndex = 20;
            this.DASHBOARD.Text = "DASHBOARD";
            this.DASHBOARD.UseVisualStyleBackColor = false;
            this.DASHBOARD.Click += new System.EventHandler(this.DASHBOARD_Click);
            // 
            // SYSTEM
            // 
            this.SYSTEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.SYSTEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SYSTEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SYSTEM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SYSTEM.Location = new System.Drawing.Point(-2, 296);
            this.SYSTEM.Name = "SYSTEM";
            this.SYSTEM.Size = new System.Drawing.Size(200, 29);
            this.SYSTEM.TabIndex = 21;
            this.SYSTEM.Text = "SYSTEM";
            this.SYSTEM.UseVisualStyleBackColor = false;
            this.SYSTEM.Click += new System.EventHandler(this.SYSTEM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.SYSTEM);
            this.panel1.Controls.Add(this.DASHBOARD);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.lbl_err);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 444);
            this.panel1.TabIndex = 83;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Location = new System.Drawing.Point(-2, 399);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(200, 29);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "QUIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Frm_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 444);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ch_Visible);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_welcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.CheckBox ch_Visible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DASHBOARD;
        private System.Windows.Forms.Button SYSTEM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
    }
}

