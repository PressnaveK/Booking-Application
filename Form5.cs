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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_welcome f2 = new Frm_welcome();
            f2.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
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
