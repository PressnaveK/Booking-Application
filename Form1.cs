using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smart_movers_company
{

    public partial class Frm_welcome : Form
    {
        public static bool login_state = false;
        public static string login_type = "";
        public static string User_login = "";
        private bool Is_entered = false;
       
       
        public Frm_welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (login_state == false)
            {
                logout();
                txt_user.Text = "";
            }
            else
            {
                login();
                txt_user.Text = User_login;
                label4.Text = "LOGGED IN AS " + login_type;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-CNFE91N\TEW_SQLEXPRESS;Initial Catalog = SMART_MOVERS  ;Integrated Security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select PASSWORD , USER_TYPE from USER_DETAIL where USER_NAME = @USER_NAME ", con);
                cmd.Parameters.AddWithValue("@USER_NAME", txt_user.Text);
                SqlDataReader da = cmd.ExecuteReader();
                da.Read();
                
                login_type = da["USER_TYPE"].ToString();
                if (txt_password.Text == da["PASSWORD"].ToString()) {
                    login();
                    User_login = txt_user.Text;
                    login_state = true;
                }

                else
                {
                    login_state = false;
                    errorProvider1.SetError(lbl_err, "Invalid Password");
                    lbl_err.Text = "Invalid Password";
                    logout();
                }
            }catch(Exception ex)
            { 
                login_state = false;
                errorProvider1.SetError(lbl_err, ex.Message);
                lbl_err.Text = "User does not exist";
                logout();
            }
           
   
            
        }
        void login()
        {
            DASHBOARD.Visible = true;
            SYSTEM.Visible = true;
            label4.Text = "LOGGED IN AS " + login_type;
            errorProvider1.SetError(lbl_err, "");
            lbl_err.Text = "Logged in sucessfully";
            txt_password.Visible = false;
            txt_user.Enabled = false;
            btn_login.Visible = false;
            btnlogout.Visible = true;
            ch_Visible.Visible = false;
           
        }
        void logout()
        {
            DASHBOARD.Visible = false;
            SYSTEM.Visible = false;
            label4.Text = "PASSWORD";
            txt_password.Visible = true;
            txt_user.Enabled = true;
            btn_login.Visible = false;
            txt_password.Text = "";
            btnlogout.Visible = false;
            ch_Visible.Visible = true;
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(lbl_err, "");
            lbl_err.Text = "";
            if (txt_password.Text == "")
            {
                btn_login.Visible = false;
            }
            else
            {
                btn_login.Visible = true;
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Is_entered = e.KeyChar == (char)13;
            errorProvider1.SetError(lbl_err, "");
            lbl_err.Text = "";
            if (txt_user.Text == "" )
            {
                btn_login.Visible = false;
            }
            else
            {
                btn_login.Visible = true;
            }
            if(e.Handled = Is_entered)
            {

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-CNFE91N\TEW_SQLEXPRESS;Initial Catalog = SMART_MOVERS  ;Integrated Security = true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select PASSWORD , USER_TYPE from USER_DETAIL where USER_NAME = @USER_NAME ", con);
                    cmd.Parameters.AddWithValue("@USER_NAME", txt_user.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    da.Read();

                    login_type = da["USER_TYPE"].ToString();
                    if (txt_password.Text == da["PASSWORD"].ToString())
                    {
                        login();
                        User_login = txt_user.Text;
                        login_state = true;
                    }

                    else
                    {
                        login_state = false;
                        errorProvider1.SetError(lbl_err, "Invalid Password");
                        lbl_err.Text = "Invalid Password";
                        logout();
                    }
                }
                catch (Exception ex)
                {
                    login_state = false;
                    errorProvider1.SetError(lbl_err, ex.Message);
                    lbl_err.Text = "User does not exist";
                    logout();
                }



            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            txt_user.Text = "";
            logout();
            errorProvider1.SetError(lbl_err, "");
            lbl_err.Text = "Logged out successfully";
            login_state = false;
            
        }

        private void ch_Visible_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_Visible.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;

            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            if(txt_user.Text == "")
            {
                btn_login.Visible = false;
            }
        }

        private void DASHBOARD_Click(object sender, EventArgs e)
        {
            this.Hide();
            DASHBOARD D = new DASHBOARD();
            D.ShowDialog();
        }

        private void SYSTEM_Click(object sender, EventArgs e)
        {
            this.Hide();
            SYSTEM S = new SYSTEM();
            S.ShowDialog();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to quit?","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            btn_login.Focus();
            
        }

    }
}
