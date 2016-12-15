namespace WindowsFormsApplication1
{
    partial class TaxApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.tb_solution = new System.Windows.Forms.TextBox();
            this.l_tRate = new System.Windows.Forms.Label();
            this.onClick_compute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solution";
            // 
            // tb_amount
            // 
            this.tb_amount.Location = new System.Drawing.Point(193, 81);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(100, 20);
            this.tb_amount.TabIndex = 3;
            this.tb_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_amount_KeyDown);
            // 
            // tb_solution
            // 
            this.tb_solution.Location = new System.Drawing.Point(193, 162);
            this.tb_solution.Name = "tb_solution";
            this.tb_solution.ReadOnly = true;
            this.tb_solution.Size = new System.Drawing.Size(100, 20);
            this.tb_solution.TabIndex = 4;
            // 
            // l_tRate
            // 
            this.l_tRate.AutoSize = true;
            this.l_tRate.Location = new System.Drawing.Point(193, 121);
            this.l_tRate.Name = "l_tRate";
            this.l_tRate.Size = new System.Drawing.Size(30, 13);
            this.l_tRate.TabIndex = 5;
            this.l_tRate.Text = "7.5%";
            // 
            // onClick_compute
            // 
            this.onClick_compute.Location = new System.Drawing.Point(193, 220);
            this.onClick_compute.Name = "onClick_compute";
            this.onClick_compute.Size = new System.Drawing.Size(75, 23);
            this.onClick_compute.TabIndex = 6;
            this.onClick_compute.Text = "Calculate";
            this.onClick_compute.UseVisualStyleBackColor = true;
            this.onClick_compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // TaxApp
            // 
            this.ClientSize = new System.Drawing.Size(546, 309);
            this.Controls.Add(this.onClick_compute);
            this.Controls.Add(this.l_tRate);
            this.Controls.Add(this.tb_solution);
            this.Controls.Add(this.tb_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaxApp";
            this.Text = "Tax App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_solution;
        private System.Windows.Forms.Label l_tRate;
        private System.Windows.Forms.Button onClick_compute;

    }
}

