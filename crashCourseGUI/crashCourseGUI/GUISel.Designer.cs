namespace crashCourseGUI
{
    partial class GUISel
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
            this.butCalc1 = new System.Windows.Forms.Button();
            this.listBox_Workers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCalc1
            // 
            this.butCalc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(22)))));
            this.butCalc1.ForeColor = System.Drawing.Color.White;
            this.butCalc1.Location = new System.Drawing.Point(818, 168);
            this.butCalc1.Name = "butCalc1";
            this.butCalc1.Size = new System.Drawing.Size(75, 23);
            this.butCalc1.TabIndex = 0;
            this.butCalc1.Text = "Press ME";
            this.butCalc1.UseVisualStyleBackColor = false;
            this.butCalc1.Click += new System.EventHandler(this.butCalc1_Click);
            // 
            // listBox_Workers
            // 
            this.listBox_Workers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox_Workers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Workers.FormattingEnabled = true;
            this.listBox_Workers.Items.AddRange(new object[] {
            "Julien Esposito",
            "Chris McCall",
            "Josh Baca",
            "Greg McKee"});
            this.listBox_Workers.Location = new System.Drawing.Point(621, 19);
            this.listBox_Workers.Name = "listBox_Workers";
            this.listBox_Workers.Size = new System.Drawing.Size(458, 143);
            this.listBox_Workers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please make your selection from the list box.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(799, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // GUISel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 413);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Workers);
            this.Controls.Add(this.butCalc1);
            this.Name = "GUISel";
            this.Text = "GUI Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCalc1;
        private System.Windows.Forms.ListBox listBox_Workers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

