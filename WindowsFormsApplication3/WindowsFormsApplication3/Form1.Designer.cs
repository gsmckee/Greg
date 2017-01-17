namespace WindowsFormsApplication3
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
            this.checkList_bagSel = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkList_bagSel
            // 
            this.checkList_bagSel.FormattingEnabled = true;
            this.checkList_bagSel.Items.AddRange(new object[] {
            "Beaded",
            "Fringed",
            "Fringed Beaded",
            "Full Decorative",
            "Needlepoint Design",
            "Plain"});
            this.checkList_bagSel.Location = new System.Drawing.Point(282, 122);
            this.checkList_bagSel.Name = "checkList_bagSel";
            this.checkList_bagSel.Size = new System.Drawing.Size(120, 94);
            this.checkList_bagSel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 429);
            this.Controls.Add(this.checkList_bagSel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkList_bagSel;
    }
}

