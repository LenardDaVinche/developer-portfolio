namespace AssignmentThreeApplication
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblhelpScreen = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblHowtoPlay = new System.Windows.Forms.Label();
            this.lblPurposeExplain = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFAQ = new System.Windows.Forms.Button();
            this.btnbackToMain = new System.Windows.Forms.Button();
            this.btncloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhelpScreen
            // 
            this.lblhelpScreen.AutoSize = true;
            this.lblhelpScreen.Font = new System.Drawing.Font("Trajan Pro", 17F);
            this.lblhelpScreen.Location = new System.Drawing.Point(12, 9);
            this.lblhelpScreen.Name = "lblhelpScreen";
            this.lblhelpScreen.Size = new System.Drawing.Size(339, 58);
            this.lblhelpScreen.TabIndex = 4;
            this.lblhelpScreen.Text = "Help Screen";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.lblPurpose.Location = new System.Drawing.Point(15, 97);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(389, 38);
            this.lblPurpose.TabIndex = 9;
            this.lblPurpose.Text = "Purpose of the Game: ";
            // 
            // lblHowtoPlay
            // 
            this.lblHowtoPlay.AutoSize = true;
            this.lblHowtoPlay.Font = new System.Drawing.Font("Trajan Pro", 11F);
            this.lblHowtoPlay.Location = new System.Drawing.Point(15, 308);
            this.lblHowtoPlay.Name = "lblHowtoPlay";
            this.lblHowtoPlay.Size = new System.Drawing.Size(248, 38);
            this.lblHowtoPlay.TabIndex = 10;
            this.lblHowtoPlay.Text = "How to Play: ";
            // 
            // lblPurposeExplain
            // 
            this.lblPurposeExplain.AutoSize = true;
            this.lblPurposeExplain.Location = new System.Drawing.Point(17, 144);
            this.lblPurposeExplain.Name = "lblPurposeExplain";
            this.lblPurposeExplain.Size = new System.Drawing.Size(0, 25);
            this.lblPurposeExplain.TabIndex = 12;
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.SystemColors.Control;
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPurpose.Location = new System.Drawing.Point(22, 144);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(1000, 161);
            this.txtPurpose.TabIndex = 14;
            this.txtPurpose.Text = resources.GetString("txtPurpose.Text");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.richTextBox1.Location = new System.Drawing.Point(22, 349);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1000, 492);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnFAQ
            // 
            this.btnFAQ.Font = new System.Drawing.Font("Trajan Pro", 10F);
            this.btnFAQ.Location = new System.Drawing.Point(22, 847);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Size = new System.Drawing.Size(298, 84);
            this.btnFAQ.TabIndex = 22;
            this.btnFAQ.Text = "Frequently Asked Questions";
            this.btnFAQ.UseVisualStyleBackColor = true;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // btnbackToMain
            // 
            this.btnbackToMain.Font = new System.Drawing.Font("Trajan Pro", 10F);
            this.btnbackToMain.Location = new System.Drawing.Point(375, 847);
            this.btnbackToMain.Name = "btnbackToMain";
            this.btnbackToMain.Size = new System.Drawing.Size(298, 84);
            this.btnbackToMain.TabIndex = 23;
            this.btnbackToMain.Text = "Back to Main Menu";
            this.btnbackToMain.UseVisualStyleBackColor = true;
            this.btnbackToMain.Click += new System.EventHandler(this.btnbackToMain_Click);
            // 
            // btncloseApp
            // 
            this.btncloseApp.Font = new System.Drawing.Font("Trajan Pro", 10F);
            this.btncloseApp.Location = new System.Drawing.Point(724, 847);
            this.btncloseApp.Name = "btncloseApp";
            this.btncloseApp.Size = new System.Drawing.Size(298, 84);
            this.btncloseApp.TabIndex = 24;
            this.btncloseApp.Text = "Close Application";
            this.btncloseApp.UseVisualStyleBackColor = true;
            this.btncloseApp.Click += new System.EventHandler(this.btncloseApp_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 958);
            this.Controls.Add(this.btncloseApp);
            this.Controls.Add(this.btnbackToMain);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.lblPurposeExplain);
            this.Controls.Add(this.lblHowtoPlay);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblhelpScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblhelpScreen;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblHowtoPlay;
        private System.Windows.Forms.Label lblPurposeExplain;
        private System.Windows.Forms.RichTextBox txtPurpose;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFAQ;
        private System.Windows.Forms.Button btnbackToMain;
        private System.Windows.Forms.Button btncloseApp;
    }
}