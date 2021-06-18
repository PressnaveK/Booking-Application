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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_welcome f2 = new Frm_welcome();
            f2.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
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
