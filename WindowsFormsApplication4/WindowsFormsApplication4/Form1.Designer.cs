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
            this.button_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_designSel = new System.Windows.Forms.ListBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.rBut_ONight = new System.Windows.Forms.RadioButton();
            this.rBut_3Day = new System.Windows.Forms.RadioButton();
            this.rBut_Standard = new System.Windows.Forms.RadioButton();
            this.tBox_shipTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sendToBasket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 22);
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
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.Color.Lime;
            this.button_Submit.Location = new System.Drawing.Point(438, 296);
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
            this.listBox_designSel.DisplayMember = "45, 25, 30, ";
            this.listBox_designSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_designSel.FormattingEnabled = true;
            this.listBox_designSel.ItemHeight = 16;
            this.listBox_designSel.Items.AddRange(new object[] {
            "Beaded",
            "Fringed",
            "Fringed beaded",
            "Full decorative",
            "Needlepoint design",
            "Plain"});
            this.listBox_designSel.Location = new System.Drawing.Point(12, 117);
            this.listBox_designSel.Name = "listBox_designSel";
            this.listBox_designSel.Size = new System.Drawing.Size(146, 100);
            this.listBox_designSel.Sorted = true;
            this.listBox_designSel.TabIndex = 7;
            this.listBox_designSel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_designSel_MouseClick);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Red;
            this.button_clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_clear.Location = new System.Drawing.Point(542, 296);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(98, 23);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Cancel Order";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.clear_selection);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(12, 322);
            this.numUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.ReadOnly = true;
            this.numUpDown.Size = new System.Drawing.Size(120, 20);
            this.numUpDown.TabIndex = 8;
            this.numUpDown.ValueChanged += new System.EventHandler(this.numUpDown1_ValueChanged);
            // 
            // rBut_ONight
            // 
            this.rBut_ONight.AutoSize = true;
            this.rBut_ONight.Location = new System.Drawing.Point(349, 152);
            this.rBut_ONight.Name = "rBut_ONight";
            this.rBut_ONight.Size = new System.Drawing.Size(99, 17);
            this.rBut_ONight.TabIndex = 9;
            this.rBut_ONight.TabStop = true;
            this.rBut_ONight.Text = "Over Night 10%";
            this.rBut_ONight.UseVisualStyleBackColor = true;
            this.rBut_ONight.CheckedChanged += new System.EventHandler(this.rBut_ONight_CheckedChanged);
            // 
            // rBut_3Day
            // 
            this.rBut_3Day.AutoSize = true;
            this.rBut_3Day.Location = new System.Drawing.Point(454, 152);
            this.rBut_3Day.Name = "rBut_3Day";
            this.rBut_3Day.Size = new System.Drawing.Size(95, 17);
            this.rBut_3Day.TabIndex = 10;
            this.rBut_3Day.TabStop = true;
            this.rBut_3Day.Text = "Three Day 7% ";
            this.rBut_3Day.UseVisualStyleBackColor = true;
            this.rBut_3Day.CheckedChanged += new System.EventHandler(this.rBut_3Day_CheckedChanged);
            // 
            // rBut_Standard
            // 
            this.rBut_Standard.AutoSize = true;
            this.rBut_Standard.Location = new System.Drawing.Point(555, 152);
            this.rBut_Standard.Name = "rBut_Standard";
            this.rBut_Standard.Size = new System.Drawing.Size(85, 17);
            this.rBut_Standard.TabIndex = 11;
            this.rBut_Standard.TabStop = true;
            this.rBut_Standard.Text = "Standard 5%";
            this.rBut_Standard.UseVisualStyleBackColor = true;
            this.rBut_Standard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tBox_shipTotal
            // 
            this.tBox_shipTotal.Location = new System.Drawing.Point(439, 250);
            this.tBox_shipTotal.Multiline = true;
            this.tBox_shipTotal.Name = "tBox_shipTotal";
            this.tBox_shipTotal.ReadOnly = true;
            this.tBox_shipTotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBox_shipTotal.Size = new System.Drawing.Size(145, 35);
            this.tBox_shipTotal.TabIndex = 12;
            this.tBox_shipTotal.Text = "1\r\n2\r\n3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quantity of bags?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total + shipping cost ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Available shipping options:";
            // 
            // sendToBasket
            // 
            this.sendToBasket.BackColor = System.Drawing.Color.Yellow;
            this.sendToBasket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendToBasket.FlatAppearance.BorderSize = 5;
            this.sendToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendToBasket.Location = new System.Drawing.Point(439, 194);
            this.sendToBasket.Name = "sendToBasket";
            this.sendToBasket.Size = new System.Drawing.Size(97, 23);
            this.sendToBasket.TabIndex = 16;
            this.sendToBasket.Text = "Send to basket";
            this.sendToBasket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendToBasket.UseVisualStyleBackColor = false;
            this.sendToBasket.Click += new System.EventHandler(this.sendToBasket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 429);
            this.Controls.Add(this.sendToBasket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox_shipTotal);
            this.Controls.Add(this.rBut_Standard);
            this.Controls.Add(this.rBut_3Day);
            this.Controls.Add(this.rBut_ONight);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.listBox_designSel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.tb_hlightSel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hlightSel;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_designSel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.RadioButton rBut_ONight;
        private System.Windows.Forms.RadioButton rBut_3Day;
        private System.Windows.Forms.RadioButton rBut_Standard;
        private System.Windows.Forms.TextBox tBox_shipTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendToBasket;
    }
}

