namespace WindowsFormsApplication1
{
    partial class List
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
            this.lstNames = new System.Windows.Forms.ListBox();
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 46;
            this.lstNames.Location = new System.Drawing.Point(1167, 151);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(746, 326);
            this.lstNames.TabIndex = 0;
            // 
            // listNumbers
            // 
            this.listNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.ItemHeight = 46;
            this.listNumbers.Location = new System.Drawing.Point(1167, 794);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(746, 326);
            this.listNumbers.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblName.Location = new System.Drawing.Point(88, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(217, 36);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Type in a name";
            // 
            // txtNames
            // 
            this.txtNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.txtNames.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNames.Location = new System.Drawing.Point(94, 151);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(854, 71);
            this.txtNames.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.numericUpDown1.Location = new System.Drawing.Point(96, 805);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(852, 71);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(89, 766);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a number (integer)";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2013, 1260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listNumbers);
            this.Controls.Add(this.lstNames);
            this.Name = "List";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

