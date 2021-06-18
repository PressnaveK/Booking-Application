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
using System.Data.Entity; // Library for data entity

namespace Smart_movers_company
{
    public partial class Form2 : Form
    {
        
        CUSTOMER Model = new CUSTOMER(); //Class for data entity of table CUSTOMER
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            populate();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DASHBOARD f2 = new DASHBOARD();
            f2.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "" || txt_ID.Text == "" || txt_Address.Text == "" || txt_TP.Text == "" || txt_Name.Text == "")
            {
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text= "Null Entry";
            }
            else if(txtType.Text == "Category-1" || txtType.Text == "Category-2" || txtType.Text == "Category-3")
            {
                try
                {
                    Model.CUSTOMER_ID = int.Parse(txt_ID.Text.Trim());
                    Model.CUSTOMER_NAME = txt_Name.Text.Trim();
                    Model.CUSTOMER_TYPE = txtType.Text.Trim();
                    Model.CUSTOMER_TEL_NO = txt_TP.Text.Trim();
                    Model.CUSTOMER_ADDRESS = txt_Address.Text.Trim();
                    using (SMART_MOVERSEntities1 db = new SMART_MOVERSEntities1())
                    {
                        db.CUSTOMERs.Add(Model);
                        db.SaveChanges();
                    }
                    populate();
                    Clear();
                    errorProvider_State.SetError(lbl_state, "");
                    lbl_state.Text = "Inserted Sucessfully";
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(lbl_error1, ex.Message);
                    lbl_error1.Text = "Already existing ID!";
                    errorProvider_State.SetError(lbl_state, "error");
                    lbl_state.Text = "Repeated Entry";
                }
                
            }
            else
            {
                errorProvider3.SetError(lbl_err_3, "error");
                lbl_err_3.Text = "Choose given options";
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Invalid Entry";
            }
        }

        
        
        void Clear()
        {
            txt_Address.Text = txt_ID.Text = txt_TP.Text = txt_Name.Text = txtType.Text = "";
            btn_insert.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            txt_ID.Enabled = true;
            errorProvider1.SetError(lbl_error1, "");
            lbl_error_2.Text = "";
            errorProvider2.SetError(lbl_error1, "");
            lbl_error1.Text = "";
            errorProvider3.SetError(lbl_err_3, "");
            lbl_err_3.Text = "";
            Model.CUSTOMER_ID = 0;
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void populate()
        {
            using (SMART_MOVERSEntities1 db = new SMART_MOVERSEntities1())
            {
                dataGridView1.DataSource = db.CUSTOMERs.ToList<CUSTOMER>();
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            Clear();
            errorProvider_State.SetError(lbl_state, "");
            lbl_state.Text = "Cleared Sucessfully";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Model.CUSTOMER_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CUSTOMER_ID"].Value);
                using (SMART_MOVERSEntities1 db = new SMART_MOVERSEntities1())
                {
                    Model = db.CUSTOMERs.Where(x => x.CUSTOMER_ID == Model.CUSTOMER_ID).FirstOrDefault();
                    txt_ID.Text = Model.CUSTOMER_ID.ToString();
                    txt_Address.Text = Model.CUSTOMER_ADDRESS;
                    txt_Name.Text = Model.CUSTOMER_NAME;
                    txtType.Text = Model.CUSTOMER_TYPE;
                    txt_TP.Text = Model.CUSTOMER_TEL_NO;
                }

                errorProvider_State.SetError(lbl_state, "");
                lbl_state.Text = "Selected Sucessfully";
                btn_insert.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
                txt_ID.Enabled = false;
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            errorProvider_State.SetError(lbl_state, "error");
            lbl_state.Text = "Warning";
            if (MessageBox.Show("Are you sure to delete?","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SMART_MOVERSEntities1 db = new SMART_MOVERSEntities1())
                {
                    var entry = db.Entry(Model);
                    if (entry.State == EntityState.Detached)
                    db.CUSTOMERs.Attach(Model);
                    db.CUSTOMERs.Remove(Model);
                    db.SaveChanges();
                    populate();
                    Clear();
                    errorProvider_State.SetError(lbl_state, "");
                    lbl_state.Text = "Deleted Sucessfully";
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "" || txt_ID.Text == "" || txt_Address.Text == "" || txt_TP.Text == "" || txt_Name.Text == "")
            {

                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Null Entry";
            }
            else if(txtType.Text =="Category-1"|| txtType.Text == "Category-2"|| txtType.Text == "Category-3")
            {
                Model.CUSTOMER_ID = int.Parse(txt_ID.Text.Trim());
                Model.CUSTOMER_NAME = txt_Name.Text.Trim();
                Model.CUSTOMER_TYPE = txtType.Text.Trim();
                Model.CUSTOMER_TEL_NO = txt_TP.Text.Trim();
                Model.CUSTOMER_ADDRESS = txt_Address.Text.Trim();
                using (SMART_MOVERSEntities1 db = new SMART_MOVERSEntities1())
                {
                    if (Model.CUSTOMER_ID == 0)

                        db.CUSTOMERs.Add(Model);
                    else
                        db.Entry(Model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                populate();
                Clear();

                errorProvider_State.SetError(lbl_state, "");
                lbl_state.Text = "Updated Sucessfully";
            }
            else
            {
                errorProvider3.SetError(lbl_err_3, "error");
                lbl_err_3.Text = "Choose given options";
                errorProvider_State.SetError(lbl_state, "error");
                lbl_state.Text = "Invalid Entry";
            }
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled =! char.IsDigit(e.KeyChar))
            {
                if (e.Handled = !char.IsControl(e.KeyChar))
                {
                    errorProvider1.SetError(lbl_error1, "Allow Only Numeric Values !");
                    lbl_error1.Text = "Only Numerical Values allowed !";
                }
            }
            else
            {
                errorProvider1.SetError(lbl_error1, "");
                lbl_error1.Text = "";

            }
        }

        private void txt_TP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled =!char.IsDigit(e.KeyChar))
            {
                if (e.Handled = !char.IsControl(e.KeyChar))
                {
                    errorProvider2.SetError(lbl_error_2, "Allow Only Numeric Values !");
                    lbl_error_2.Text = "Only Numerical Values allowed !";
                }
            }
            else
            {
                errorProvider2.SetError(lbl_error_2, "");
                lbl_error_2.Text = "";

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            txtType.DroppedDown = true;
            
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if(txtType.Text == "Category-1"||txtType.Text == "Category-2"||txtType.Text == "Category-3") {
                txtType.ForeColor = Color.Black;
                errorProvider3.SetError(lbl_err_3, "");
                lbl_err_3.Text = "";
            }
            else
            {
                txtType.ForeColor = Color.Red;
                errorProvider3.SetError(lbl_err_3, "error");
                lbl_err_3.Text = "Choose given options";
            }
        }

        
    }
    
}
