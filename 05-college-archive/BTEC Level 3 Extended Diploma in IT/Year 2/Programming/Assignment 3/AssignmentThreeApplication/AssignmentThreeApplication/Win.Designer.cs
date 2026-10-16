namespace AssignmentThreeApplication
{
    partial class Win
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
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWinClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trajan Pro", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(389, 87);
            this.label13.TabIndex = 5;
            this.label13.Text = "You Win!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssignmentThreeApplication.Properties.Resources.e4bcedfa06cd024992690d4fe944c8419db4eaf7_hq;
            this.pictureBox1.Location = new System.Drawing.Point(27, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnWinClose
            // 
            this.btnWinClose.Font = new System.Drawing.Font("Trajan Pro", 10F);
            this.btnWinClose.Location = new System.Drawing.Point(27, 279);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(374, 90);
            this.btnWinClose.TabIndex = 22;
            this.btnWinClose.Text = "Close";
            this.btnWinClose.UseVisualStyleBackColor = true;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 389);
            this.Controls.Add(this.btnWinClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnWinClose;
    }
}