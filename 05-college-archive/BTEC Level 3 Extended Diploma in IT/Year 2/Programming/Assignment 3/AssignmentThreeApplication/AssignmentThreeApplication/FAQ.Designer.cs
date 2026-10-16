namespace AssignmentThreeApplication
{
    partial class FAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQ));
            this.listFAQ = new System.Windows.Forms.ListBox();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.lblFAQ = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.txtPurpose = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listFAQ
            // 
            this.listFAQ.FormattingEnabled = true;
            this.listFAQ.ItemHeight = 25;
            this.listFAQ.Location = new System.Drawing.Point(12, 283);
            this.listFAQ.Name = "listFAQ";
            this.listFAQ.Size = new System.Drawing.Size(609, 254);
            this.listFAQ.TabIndex = 1;
            this.listFAQ.SelectedIndexChanged += new System.EventHandler(this.listFAQ_SelectedIndexChanged);
            // 
            // btnFAQ
            // 
            this.btnFAQ.Location = new System.Drawing.Point(627, 283);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(140, 254);
            this.btnFAQ.TabIndex = 17;
            this.btnFAQ.Text = "Generate Questions";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // lblFAQ
            // 
            this.lblFAQ.AutoSize = true;
            this.lblFAQ.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.lblFAQ.Location = new System.Drawing.Point(85, 9);
            this.lblFAQ.Name = "lblFAQ";
            this.lblFAQ.Size = new System.Drawing.Size(602, 38);
            this.lblFAQ.TabIndex = 19;
            this.lblFAQ.Text = "FAQ (Frequently Asked Questions)";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 543);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(745, 168);
            this.txtAnswer.TabIndex = 20;
            this.txtAnswer.Text = "";
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.SystemColors.Control;
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPurpose.Location = new System.Drawing.Point(12, 55);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(755, 222);
            this.txtPurpose.TabIndex = 21;
            this.txtPurpose.Text = resources.GetString("txtPurpose.Text");
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 723);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblFAQ);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.listFAQ);
            this.Name = "FAQ";
            this.Text = "FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFAQ;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Label lblFAQ;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.RichTextBox txtPurpose;
    }
}