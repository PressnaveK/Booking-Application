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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void txt_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_welcome f2 = new Frm_welcome();
            f2.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DASHBOARD f2 = new DASHBOARD();
            f2.ShowDialog();
        }
    }
}
