namespace AssignmentThreeApplication
{
    partial class Lose
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
            this.btnLoseClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trajan Pro", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(376, 87);
            this.label13.TabIndex = 7;
            this.label13.Text = "You Lose";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssignmentThreeApplication.Properties.Resources._8021744fc275101ed9a4b75ace41f168;
            this.pictureBox1.Location = new System.Drawing.Point(77, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoseClose
            // 
            this.btnLoseClose.Font = new System.Drawing.Font("Trajan Pro", 10F);
            this.btnLoseClose.Location = new System.Drawing.Point(14, 304);
            this.btnLoseClose.Name = "btnLoseClose";
            this.btnLoseClose.Size = new System.Drawing.Size(374, 90);
            this.btnLoseClose.TabIndex = 23;
            this.btnLoseClose.Text = "Close";
            this.btnLoseClose.UseVisualStyleBackColor = true;
            this.btnLoseClose.Click += new System.EventHandler(this.btnLoseClose_Click);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 406);
            this.Controls.Add(this.btnLoseClose);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lose";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoseClose;
    }
}