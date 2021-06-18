using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Smart_movers_company
{
    public partial class SYSTEM : Form
    {
        USER_DETAIL Model = new USER_DETAIL();
        public SYSTEM()
        {
            InitializeComponent();
        }

        private void SYSTEM_Load(object sender, EventArgs e)
        {
            if (Frm_welcome.login_type == "ADMIN")
            {
                Clear();
                populate();
            }
            else
            {
                Model.USER_NAME = Frm_welcome.User_login;

                using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
                {
                    Model = db.USER_DETAIL.Where(x => x.USER_NAME == Model.USER_NAME).FirstOrDefault();
                    txt_User.Text = Model.USER_NAME;
                    txt_type.Text = Model.USER_TYPE;
                    txt_Password.Text = Model.PASSWORD;
                }
                txt_User.Enabled = false;
                txt_type.Enabled = false;
                dataGridView1.Visible = false;
                btn_insert.Enabled = false;
                btn_insert.Visible = false;
                btn_Delete.Enabled = false;
                btn_Delete.Visible = false;
                this.Size = new Size(600,300);
            }
        }

        private void txt_type_TextChanged(object sender, EventArgs e)
        {
            if (txt_type.Text == "ADMIN" || txt_type.Text == "EDITOR")
            {
                txt_type.ForeColor = Color.Black;
                errorProvider1.SetError(lbl_err1, "");
                lbl_err1.Text = "";
            }
            else
            {
                txt_type.ForeColor = Color.Red;
                errorProvider1.SetError(lbl_err1, "error");
                lbl_err1.Text = "Choose given options";

            }
        }
        void populate()
        {
            using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
            {
                dataGridView1.DataSource = db.USER_DETAIL.ToList<USER_DETAIL>();
            }
        }
        void Clear()
        {
            txt_type.Text =txt_Password.Text = txt_User.Text = "";
            btn_insert.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            txt_User.Enabled = true;
            errorProvider1.SetError(lbl_err1, "");
            lbl_err1.Text = "";
            Model.USER_NAME= "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_type.Text == "" || txt_Password.Text == "" || txt_User.Text == "")
            {
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Null Entry";
            }
            else if (txt_type.Text == "ADMIN" || txt_type.Text == "EDITOR" )
            {
                try
                {
                    Model.USER_NAME = txt_User.Text.Trim();
                    Model.PASSWORD = txt_Password.Text.Trim();
                    Model.USER_TYPE = txt_type.Text.Trim();
                    using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
                    {
                        db.USER_DETAIL.Add(Model);
                        db.SaveChanges();
                    }
                    populate();
                    Clear();
                    errorProvider_State.SetError(lbl_state, "");
                    lbl_state.Text = "Inserted Sucessfully";
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(lbl_err1, ex.Message);
                    lbl_err1.Text = "Already existing ID!";
                    errorProvider_State.SetError(lbl_state, "error");
                    lbl_state.Text = "Repeated Entry";
                }

            }
            else
            {
                errorProvider1.SetError(lbl_err1, "error");
                lbl_err1.Text = "Choose given options";
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Invalid Entry";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Model.USER_NAME = dataGridView1.CurrentRow.Cells["USER_NAME"].Value.ToString();
                using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
                {
                    Model = db.USER_DETAIL.Where(x => x.USER_NAME == Model.USER_NAME).FirstOrDefault();
                    txt_User.Text = Model.USER_NAME;
                    txt_type.Text = Model.USER_TYPE;
                    txt_Password.Text = Model.PASSWORD;
                    if(Model.USER_TYPE == "ADMIN")
                    {
                        txt_type.Enabled = false;
                    }
                    else
                    {
                        txt_type.Enabled = true;
                    }
                }

                errorProvider_State.SetError(lbl_state, "");
                lbl_state.Text = "Selected Sucessfully";
                btn_insert.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
                txt_User.Enabled = false;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_type.Text == "" || txt_Password.Text == "" || txt_User.Text == "")
            {

                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Null Entry";
            }
            else if (txt_type.Text == "ADMIN" || txt_type.Text == "EDITOR")
            {
                Model.USER_NAME = txt_User.Text.Trim();
                Model.PASSWORD = txt_Password.Text.Trim();
                Model.USER_TYPE = txt_type.Text.Trim();
                using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
                {

                    if (Model.USER_NAME == "")

                        db.USER_DETAIL.Add(Model);
                    else
                        db.Entry(Model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                errorProvider_State.SetError(lbl_state, "");
                lbl_state.Text = "Updated Sucessfully";
                if (Frm_welcome.login_type == "ADMIN")
                {
                    if (txt_User.Text == Frm_welcome.User_login)
                    {
                        if (MessageBox.Show("You will be logged out", "Logout", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            Frm_welcome.login_state = false;
                            this.Hide();
                            Frm_welcome F = new Frm_welcome();
                            F.ShowDialog();
                        }

                    }
                    else
                    {
                        populate();
                        Clear();
                    }
                }else if (MessageBox.Show("You will be logged out","Logout",MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Frm_welcome.login_state = false;
                    this.Hide();
                    Frm_welcome F = new Frm_welcome();
                    F.ShowDialog();
                }
                

            }
            else
            {
                errorProvider1.SetError(lbl_err1, "error");
                lbl_err1.Text = "Choose given options";
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Invalid Entry";
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            errorProvider_State.SetError(lbl_state, "error");
            lbl_state.Text = "Warning";
            if (MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SMART_MOVERSEntities2 db = new SMART_MOVERSEntities2())
                {
                    var entry = db.Entry(Model);
                    if (entry.State == EntityState.Detached)
                        db.USER_DETAIL.Attach(Model);
                    db.USER_DETAIL.Remove(Model);
                    db.SaveChanges();
                    populate();
                    Clear();
                    errorProvider_State.SetError(lbl_state, "");
                    lbl_state.Text = "Deleted Sucessfully";
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
            errorProvider_State.SetError(lbl_state, "");
            lbl_state.Text = "Cleared Sucessfully";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_welcome f2 = new Frm_welcome();
            f2.ShowDialog();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }


}
