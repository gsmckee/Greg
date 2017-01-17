using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crashCourseGUI
{
    public partial class GUISel : Form
    {
        public GUISel()
        {
            InitializeComponent();
        }

        private void butCalc1_Click(object sender, EventArgs e)
        {
            //string selectedText= this.listBox_Workers.SelectedItem.ToString();
            //this.textBox1.Text = selectedText;
            this.textBox1.Text = this.listBox_Workers.SelectedItem.ToString();
        }
    }
}
