namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.tb_hlightSel = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_designSel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOM BAGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select a design for your bag.";
            // 
            // tb_hlightSel
            // 
            this.tb_hlightSel.Location = new System.Drawing.Point(12, 252);
            this.tb_hlightSel.Name = "tb_hlightSel";
            this.tb_hlightSel.ReadOnly = true;
            this.tb_hlightSel.Size = new System.Drawing.Size(120, 20);
            this.tb_hlightSel.TabIndex = 3;
            this.tb_hlightSel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_clear.Location = new System.Drawing.Point(155, 117);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(98, 23);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear Selection";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            this.button_clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_clear_KeyPress);
            this.button_clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_clear_Click);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.Lime;
            this.button_Submit.Location = new System.Drawing.Point(34, 278);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(98, 23);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your Selection:";
            // 
            // listBox_designSel
            // 
            this.listBox_designSel.FormattingEnabled = true;
            this.listBox_designSel.Items.AddRange(new object[] {
            "Beaded",
            "Fringed",
            "Fringed beaded",
            "Full decorative",
            "Needlepoint design",
            "Plain"});
            this.listBox_designSel.Location = new System.Drawing.Point(12, 117);
            this.listBox_designSel.Name = "listBox_designSel";
            this.listBox_designSel.Size = new System.Drawing.Size(120, 95);
            this.listBox_designSel.Sorted = true;
            this.listBox_designSel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 429);
            this.Controls.Add(this.listBox_designSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.tb_hlightSel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hlightSel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_designSel;
    }
}

