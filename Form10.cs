using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_movers_company
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {
            lbl_roll.Text = Frm_welcome.login_type;
            lbl_user.Text = Frm_welcome.User_login;
        }

        private void Frm_2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F = new Form2();
            F.ShowDialog();
        }

        private void Frm_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F = new Form3();
            F.ShowDialog();
        }

        private void Frm_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F = new Form4();
            F.ShowDialog();
        }

        private void Frm_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F = new Form5();
            F.ShowDialog();
        }

        private void Frm_6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F = new Form6();
            F.ShowDialog();
        }

        private void Frm_7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F = new Form7();
            F.ShowDialog();
        }

        private void Frm_8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 F = new Form8();
            F.ShowDialog();
        }

        private void Frm_9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 F = new Form9();
            F.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_welcome F = new Frm_welcome();
            F.ShowDialog();
        }
    }
}
