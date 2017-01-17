using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TaxApp : Form
    {
        public TaxApp()
        {
            InitializeComponent();
        }

        private void compute_Click(object sender, EventArgs e)
        {
            double price = double.Parse(tb_amount.Text);
            double tax = double.Parse(l_tRate.Text.Split('%')[0]);
            tb_solution.Text = ((tax / 100) * price).ToString("c");
        }

        private void tb_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                compute_Click(this, e);
            }
        }
        
    }
}
