using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWeekThree
{
    public partial class Form1 : Form
    {
        int designValue = 0;
        double shipRate;
        int quantity;
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox_designSel_MouseClick(object sender, MouseEventArgs e)
        {
            string sel = this.listBox_designSel.SelectedItem.ToString();
            if (sel == "Beaded")
            {
                designValue = 45;
            }
            else if (sel == "Fringed")
            {
                designValue = 25;
            }
            else if (sel == "Fringed beaded")
            {
                designValue = 30;
            }
            else if (sel == "Full decorative")
            {
                designValue = 50;
            }
            else if (sel == "Needlepoint design")
            {
                designValue = 40;            
            }
            else
            {
                designValue = 20;
            }
            tb_hlightSel.Text = (sel + " $" + designValue);

        }

        private void clear_selection(object sender, EventArgs e)
        {
            bool res = String.IsNullOrEmpty( tb_hlightSel.Text );
            // clear the textbox...
            if (res == false)
            { 
                tb_hlightSel.Text = String.Empty;
                rBut_ONight.Checked = false;
                rBut_3Day.Checked = false;
                rBut_Standard.Checked = false;
                numUpDown.Value = 0;

            }
            else
            {
                MessageBox.Show("There is nothing to clear");
            }
        }
        private void numUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void rBut_ONight_CheckedChanged(object sender, EventArgs e)
        {
            if (shipRate == 0)
            {
                shipRate = designValue * .1;
            }
            else { }
        }

        private void rBut_3Day_CheckedChanged(object sender, EventArgs e)
        {
            if (shipRate == 0)
            {
                shipRate = designValue * .07;
            }
            else { }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (shipRate == 0)
            {
                shipRate = designValue * .05;
            }
            else { }
        }

        private void sendToBasket_Click(object sender, EventArgs e)
        {
            this.tBox_shipTotal.Text = (designValue * Convert.ToDouble( numUpDown.Value ) + shipRate).ToString();
        }

    }
}
